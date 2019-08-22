using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace CodeVerse.ClientConnector.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TcpClient> clients = new List<TcpClient>();
            for (int i = 0; i < 2; i++)
            {
                clients.Add(new TcpClient("localhost", 45385));
            }
            Console.WriteLine("Press key to exit...");
            Console.ReadKey();
            foreach (var client in clients)
            {
                client.Close();
            }
        }
    }
}
