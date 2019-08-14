using System;
using System.Net.Sockets;
using CodeVerse.ClientConnector;

namespace CodeVerse.ClientConnector.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("localhost",1337);

            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                byte[] _msg = System.Text.Encoding.UTF8.GetBytes("HELLO WORLD!");
                client.GetStream().Write(_msg, 0, _msg.Length);
            }
            client.Close();
        }
    }
}
