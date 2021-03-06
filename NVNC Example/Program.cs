﻿using System;
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

            bool retry = false;
            do
            {
                if (retry)
                    Console.WriteLine("Retry");
                try
                {
                    s.Start();
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                if (Debugger.IsAttached)
                {
                    retry = true;
                    continue;
                }
                else
                    Console.ReadLine();


            } while (true);
        }
    }

    public class VncServerTest : VncServer
    {
        public VncServerTest(string password, int port, string name)
            : base(password, port, name)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (Debugger.IsAttached)
                Debugger.Break();

            if (!(e.ExceptionObject is Exception))
                return;
            this.LastError = e.ExceptionObject as Exception;

            Console.WriteLine(this.LastError.Message);
            if (this.LastError.InnerException != null)
                Console.WriteLine(this.LastError.InnerException.Message);

        }

        public override void Start()
        {
            //if (Debugger.IsAttached)
            //    Debugger.Break();

            base.Start();
        }
    }
}
