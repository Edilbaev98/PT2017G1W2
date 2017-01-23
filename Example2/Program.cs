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

        static void Ex5()
        {
            StreamWriter st = new StreamWriter(@"c:\work\a.txt");
            st.WriteLine("Hello world");
            st.Close();
        }

        static void Ex6()
        {
            StreamReader sr = new StreamReader(@"C:\work\input.txt");
            string s = sr.ReadLine(); // "10 12"
            string[] arr = s.Split(); // arr[0] = "10", arr[1] = "12"
            int a = int.Parse(arr[0]); // a = 10
            int b = int.Parse(arr[1]); // b = 12
            Console.WriteLine(a + b); // 22
            Console.ReadKey();
            sr.Close();
        }

        static void Ex7()
        {
            StreamReader sr = new StreamReader(@"c:\work\input.txt");
            StreamWriter sw = new StreamWriter(@"c:\work\output.txt");
            string[] arr = sr.ReadLine().Split();
            int sum = 0;
            foreach (string s in arr) {
                sum += int.Parse(s);
            }
            sw.WriteLine(sum);
            sr.Close();
            sw.Close();
        }

        class Point
        {
            int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return x + " " + y;
            }
        }

        static void Ex8()
        {
            StreamReader sr = new StreamReader(@"c:\work\points.txt");
            string[] arr = sr.ReadLine().Split(); // arr[0] = "1:2" arr[1] = "5:4"...
            List<Point> points = new List<Point>();

            foreach (string s in arr)
            {
                // s = "1:2" x = 1, y = 2
                string[] a = s.Split(':'); // a[0] = 1, a[1] = 2
                Point p = new Point(int.Parse(a[0]), int.Parse(a[1]));
                points.Add(p);
            }

            foreach (Point p in points)
            {
                Console.WriteLine(p);
            }
            sr.Close();
            Console.ReadKey();
        }
        // DriveInfo
        // File Directory Path
        // StreamReader, StreamWriter => FileSteram
        static void Main(string[] args)
        {
            Ex8();
        }
    }
}
