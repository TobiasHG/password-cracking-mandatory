using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCracking
{
    class Server
    {

        public void Listen(int port)
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, port);
            server.Start();
            Console.WriteLine("Server is listening on port " + port);

            TcpClient connectionSocket = server.AcceptTcpClient();
            Console.WriteLine("Client connected");
            Stream ns = connectionSocket.GetStream();

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            string request = sr.ReadLine();

            Console.WriteLine("request = " + request);

            if(request == "password")
            {
                sw.WriteLine("password1");
            }
            else if (request == "chuck")
            {
                sw.WriteLine("chuck");
            }


;        }
    }
}
