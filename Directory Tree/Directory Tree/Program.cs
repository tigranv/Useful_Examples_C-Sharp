using System;
using System.Linq;
using System.IO;

namespace Directory_Tree
{
    class Program
    {
        public static void DirectoryPath(string path)
        {

            string[] directories = path.Split('\\');
            string path1 = "";
            int cursorUp = 0;
            int cursorLeft = 0;

            for (int i = 0; i < directories.Length - 1; i++)
            {
                path1 += directories[i] + @"\";
                string[] files = Directory.GetDirectories(path1).Select(Path.GetFileName).ToArray(); ;
                int j = 0;
                int longestfile = (files).Where(s => s.Length == files.Max(m => m.Length)).First().Length;

                foreach (string name in files)
                {
                    if (name != directories[i + 1])
                    {
                        Console.SetCursorPosition(cursorLeft + i, cursorUp + j);
                        Console.WriteLine("+" + name);
                        j++;
                    }
                    else
                    {
                        if (i != directories.Length - 2)
                        {
                            Console.SetCursorPosition(cursorLeft + i, cursorUp + j);
                            Console.WriteLine("-" + name + new string('-', longestfile - directories[i + 1].Length) + ">");
                            j++;
                        }
                        else
                        {
                            Console.SetCursorPosition(cursorLeft + i, cursorUp + j);
                            Console.WriteLine(name);
                        }

                    }
                }
                cursorUp += Array.IndexOf(files, directories[i + 1]) + 1;
                cursorLeft += longestfile + 1;
            }
        }

        static void Main(string[] args)
        {
            DirectoryPath(@"C:\Users\Tigran PC\Desktop\C#\Books FP");
            Console.ReadKey();
        }
    }
}
