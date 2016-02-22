using UnityEngine;
using System.Collections;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

public class Controller : MonoBehaviour {
	// Use this for initialization
	public Socket clientSocket;
	public byte command=0;
	public string instruction;

	void Start () 
	{
		clientSocket = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.1.108"), 5113);
		try  					
		{  
			clientSocket.Connect(ipe);  		
			Debug.Log(" Connect Success IP: " + "192.168.1.108" + " Port : " + "5113");  
		} 
		catch (Exception e)  			
		{  
			Debug.LogError(e.ToString());  	
		}

	}

	void OnGUI()
	{
		if(GUI.Button(new Rect (300, 10, 150, 50), "常速前进"))  
		{  			
			command=5;//00000101
			instruction="常速前进";
			Debug.Log("command="+instruction);
			clientSocket.Send(new byte[]{command});
		}
		if(GUI.Button (new Rect (300, 60, 150, 50), "原地左转"))  
		{  			
			command=6;//00000110
			instruction="原地左转";
			Debug.Log("command="+instruction);
			clientSocket.Send(new byte[]{command});
		}  
		if(GUI.Button (new Rect (300, 110, 150, 50), "原地右转"))  
		{  			
			command=9;//00001001
			instruction="原地右转";
			Debug.Log("command="+instruction);
			clientSocket.Send(new byte[]{command});
		}  
		if(GUI.Button (new Rect (300, 160, 150, 50), "常速后退"))  
		{  			
			command=10;//00001010
			instruction="常速后退";
			Debug.Log("command="+instruction);
			clientSocket.Send(new byte[]{command});
		}  
		if(GUI.Button (new Rect (300, 210, 150, 50), "手夹半开"))  
		{  			
			command=128;//10000000
			instruction="手夹半开";
			Debug.Log("command="+instruction);
			clientSocket.Send(new byte[]{command});
		}  
		if(GUI.Button (new Rect (300, 260, 150, 50), "前进关手"))  
		{  			
			command=245;//11110101
			instruction="前进关手";
			Debug.Log("command="+instruction);
			clientSocket.Send(new byte[]{command});
		}  
		if(GUI.Button (new Rect (300, 310, 150, 50), "原地复位"))  
		{  			
			command=0;//00000000
			instruction="原地复位";
			Debug.Log("command="+instruction);
			clientSocket.Send(new byte[]{command});
		}  
	}
	// Update is called once per frame
	void Update () {

	}
}
