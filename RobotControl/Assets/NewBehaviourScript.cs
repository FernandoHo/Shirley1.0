using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Text;
public class NewBehaviourScript : MonoBehaviour {
	public Socket socket;
	public byte command;
	// Use this for initialization
	void Start () {
		socket = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		IPEndPoint ipe = new IPEndPoint (IPAddress.Parse ("192.168.1.102"), 5113);
		socket.Connect (ipe);
		command=0;
		socket.Send (new byte[]{command});

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
