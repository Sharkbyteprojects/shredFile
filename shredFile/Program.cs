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
        void shred(string file, bool itl)
        {
            if (File.Exists(file))
            {
                byte[] bytel = File.ReadAllBytes(file);
                int lengths = bytel.Length;
                byte[] overrides = new byte[lengths + 2];
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
        void shit(string[] args, int iteration, out bool containing)
        {
            containing = false;
            bool rr = true;
            if (iteration != 1)
            {
                rr = false;
            }
            foreach (string arg in args)
            {
                FileAttributes attr = File.GetAttributes(arg);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    if (Directory.Exists(arg))
                    {
                        shredcode(Directory.GetFiles(arg));
                        shredcode(Directory.GetDirectories(arg));
                    }
                }
                else
                {
                    if (File.Exists(arg))
                    {
                        containing = true;
                        Console.WriteLine("Shred[" + iteration.ToString() + "]: " + arg);
                        try
                        {
                            shred(arg, rr);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error in shred file " + arg + ". Fail: " + e.Message + ".");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error in shred file " + arg + ". File dosn't exist!");
                    }
                }
            }
        }
        static Program shredcode(string[] args)
        {
            Program xx = new Program();
            for (int xy = 0; xy < 10; xy++)
            {
                bool ouuuuu = false;
                xx.shit(args, (xy + 1), out ouuuuu);
                if (ouuuuu)
                {
                    Thread.Sleep(50);
                }
                else
                {
                    break;
                }
            }
            Thread.Sleep(10);
            foreach (string arg in xx.files)
            {
                FileAttributes attr = File.GetAttributes(arg);
                if (!((attr & FileAttributes.Directory) == FileAttributes.Directory))
                {
                    Console.WriteLine("Unlink: " + arg);
                    File.Delete(arg);
                }
            }
            return xx;
        }
        static void deldir(string dir)
        {
            string[] subdir = Directory.GetDirectories(dir);
            foreach (string sudi in subdir)
            {
                deldir(sudi);
            }
            try
            {
                Console.WriteLine("Unlink Dir: " + dir);
                Directory.Delete(dir);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Unlink: " + dir);
            }
        }
        static void Main(string[] args)
        {
            logo();
            Program xxx = shredcode(args);
            foreach (string arg in args)
            {
                if (!xxx.files.Contains(arg))
                {
                    FileAttributes attr = File.GetAttributes(arg);
                    if (((attr & FileAttributes.Directory) == FileAttributes.Directory))
                    {
                        deldir(arg);
                    }
                }
            }
            Console.WriteLine("Press any Key to exit");
            Console.ReadKey();
        }
    }
}
