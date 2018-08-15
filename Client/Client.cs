using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        TcpClient client;
        NetworkStream stream;
        public string userId;
        public Client(TcpClient Client, NetworkStream Stream)
        {
            client = Client;
            userId = "User";
            stream = Stream;
        }
        public void Send(string Message)
        {
            byte[] message = Encoding.ASCII.GetBytes(Message);
            stream.Write(message, 0, message.Count());
        }
        public string Recieve()
        {
            byte[] recievedMessage = new byte[256];
            stream.Read(recievedMessage, 0, recievedMessage.Length);
            UI.DisplayMessage(Encoding.ASCII.GetString(recievedMessage));
            Console.WriteLine(recievedMessageString);
            return recievedMessageString;
        }
    }
}
