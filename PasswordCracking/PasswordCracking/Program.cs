using System;

namespace PasswordCracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Listen(6789);

        }
    }
}
