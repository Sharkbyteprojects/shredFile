using System;
using System.Collections.Generic;
using System.IO;

namespace shredFile
{
    class Program
    {
        public List<string> files = new List<string>();
        public void todo(string file)
        {
            if (File.Exists(file))
            {
                byte[] bytel = File.ReadAllBytes(file);
                int lengths = bytel.Length;
                byte[] overrides = new byte[lengths + 80];
                File.WriteAllBytes(file, overrides);
                files.Add(file);
            }
        }
        static void Main(string[] args)
        {
            Program xx = new Program();
            foreach (string arg in args)
            {
                Console.WriteLine("Shred: " + arg);
                try
                {
                    xx.todo(arg);
                }catch(Exception e)
                {
                    Console.WriteLine("Error in shred file " + arg);
                }
            }
            foreach(string arg in xx.files)
            {
                Console.WriteLine("Delete: " + arg);
                File.Delete(arg);
            }
            Console.ReadKey();
        }
    }
}
