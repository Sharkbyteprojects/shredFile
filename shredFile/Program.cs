using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace shredFile
{
    class Program
    {
        Random random = new Random();
        public List<string> files = new List<string>();
        public void shred(string file, bool itl)
        {
            if (File.Exists(file))
            {
                byte[] bytel = File.ReadAllBytes(file);
                int lengths = bytel.Length;
                byte[] overrides = new byte[lengths + 2];//To make overwriting sure add 10 bytes
                // USE RANDOM BYTES:
                random.NextBytes(overrides);
                File.WriteAllBytes(file, overrides);
                if (itl)
                {
                    files.Add(file);
                }
            }
        }
        static void logo()
        {
            string[] logoe = {
                "##############################################",
                "#>                                           #",
                "# >                                          #",
                "#  >         <c> Sharkbyteprojects           #",
                "# >                                          #",
                "#>                                           #",
                "##############################################",
                ""
            };
            foreach (string logoline in logoe)
            {
                Console.WriteLine(logoline);
				Thread.Sleep(50);
            }
        }
        static void shit(Program xx, string[] args, int iteration)
        {
            bool rr = true;
            if (iteration != 1)
            {
                rr = false;
            }
            foreach (string arg in args)
            {
                Console.WriteLine("Shred[" + iteration.ToString() + "]: " + arg);
                try
                {
                    xx.shred(arg, rr);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error in shred file " + arg);
                }
            }
        }
        static void Main(string[] args)
        {
            logo();
            Program xx = new Program();
            for (int xy = 0; xy < 10; xy++)
            {
                shit(xx, args, (xy + 1));
                Thread.Sleep(50);
            }
            Thread.Sleep(1000);
            foreach (string arg in xx.files)
            {
                Console.WriteLine("Unlink: " + arg);
                File.Delete(arg);
            }
            Console.WriteLine("Press any Key to exit");
            Console.ReadKey();
        }
    }
}
