using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CopyMusicas
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Faça:");
                Console.WriteLine(@"CopyMusicas X:\");
                Console.ReadKey();
                return;
            }
            PegaInfos(args[0]);
            Console.ReadKey();
        }

        static void PegaInfos(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            foreach (string fl in files)
            {
                CopyFile(fl);
            }
            string[] dirs = Directory.GetDirectories(dir);
            foreach (string dr in dirs)
            {
                PegaInfos(dr);
            }
        }

        static void CopyFile(string path)
        {
            string caminho = AppDomain.CurrentDomain.BaseDirectory;
            caminho = Path.Combine(caminho, Path.GetDirectoryName(path));
            Console.WriteLine(path);
            // File.Copy(caminho, caminho);
        }
    }
}
