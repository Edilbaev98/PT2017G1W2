using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example2
{
    /// <summary>
    /// DirectoryInfo
    /// FileInfo
    /// 
    /// </summary>

    class Program
    {
        static void Ex1()
        {
            DirectoryInfo directory = new DirectoryInfo(@"c:\Windows");
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.FullName);
            Console.ReadKey();
        }
        static void Ex2()
        {
            DirectoryInfo directory = new DirectoryInfo(@"c:\Windows");
            // Getting files.
            FileInfo[] files = directory.GetFiles();

            // Getting directories
            DirectoryInfo[] directories = directory.GetDirectories();

            Console.WriteLine(files.Length);
            Console.WriteLine(directories.Length);
            Console.ReadKey();
        }
        static void Ex3()
        {
            DirectoryInfo directory = new DirectoryInfo(@"c:\Windows");
            // Getting files.
            FileInfo[] files = directory.GetFiles();

            // Getting directories
            DirectoryInfo[] directories = directory.GetDirectories();

            Console.WriteLine("Files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Directories:");

            foreach (DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
            Console.ReadKey();
        }

        static void emptySpace(int level)
        {
            for (int i = 0; i < level * 2; i++)
                Console.Write(" ");
        }

        static void Ex4(string path, int level)
        {
            if (level > 2)
                return;
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles();
                DirectoryInfo[] directories = directory.GetDirectories();

                foreach (FileInfo file in files)
                {
                    emptySpace(level);
                    Console.WriteLine(file.Name);
                }
                foreach (DirectoryInfo dInfo in directories)
                {
                    emptySpace(level);
                    Console.WriteLine(dInfo.Name);
                    Ex4(dInfo.FullName, level + 1);
                }
            }
            catch (Exception e)
            {

            }
        }
        static void Main(string[] args)
        {
            Ex4(@"C:\Windows", 0);
        }
    }
}
