using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCrackerSlave
{
    class Slave
    {
        public void Connect(String ip, int port)
        {
            TcpClient clientSocket = new TcpClient(ip, port);

            Stream ns = clientSocket.GetStream();

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            sw.AutoFlush = true;

            sw.WriteLine("password");

            string response = sr.ReadLine();

            Console.WriteLine("response: " + response);

        }
    }
}
