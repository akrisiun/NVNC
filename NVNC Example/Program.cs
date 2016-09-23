using System;
using System.Collections.Generic;
using System.Text;
using NVNC;
using System.Diagnostics;

namespace VNCTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Vnc debug?");
            Console.ReadKey();
            if (Debugger.IsAttached)
                Debugger.Launch();

#endif

            // T!T@N VncServer("T!T@N", 5900, "T!T@N-VNC");
            var s = new VncServerTest("123", 5900, "admin");
            try
            {
                s.Start();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.ReadLine();
        }
    }

    public class VncServerTest : VncServer
    {
        public VncServerTest(string password, int port, string name)
            : base(password, port, name)
        {

        }

        public override void Start()
        {
            if (Debugger.IsAttached)
                Debugger.Break();

            base.Start();
        }
    }
}
