using System;

namespace PasswordCrackerSlave
{
    class Program
    {
        static void Main(string[] args)
        {
            Slave slave = new Slave();
            slave.Connect("localhost", 6789);
        }
    }
}
