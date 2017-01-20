using System;
using System.Linq;
using System.IO;

namespace Directory_Tree
{
    class Program
    {
        public static void DirectoryTree(string path)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] directories = path.Split('\\');
            string path1 = "";
            int cursorUp = 0;
            int cursorLeft = 0;

            for (int i = 0; i < directories.Length - 1; i++)
            {
                path1 += directories[i] + @"\";
                string[] folders = Directory.GetDirectories(path1).Select(Path.GetFileName).ToArray();
                string[] files = new DirectoryInfo(path1).GetFiles().Select(o => o.Name).ToArray();
                int j = 0;
                int longestFolder = (folders).Where(s => s.Length == folders.Max(m => m.Length)).First().Length;
                //int longestFle = (files).Where(s => s.Length == files.Max(m => m.Length)).First().Length;
                //int longestName = (longestFle>=longestFolder?longestFle:longestFolder)<25? (longestFle >= longestFolder ? longestFle : longestFolder):20;
                int longestName = longestFolder; //longestFolder <= 25 ? longestFolder : 26;

                foreach (string name in folders)
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
                            Console.WriteLine("-" + name + new string('-', longestName + 3 - directories[i + 1].Length) + "\u261B");
                            j++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(cursorLeft + i, cursorUp + j);
                            Console.WriteLine("***"+name+"***");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            j++;
                        }
                    }
                }

                //foreach (string name in files)
                //{
                //    if (name.Length < longestName) Console.WriteLine("+" + name);
                //    else Console.WriteLine("Too long name");
                //    j++;
                //}
                cursorUp += Array.IndexOf(folders, directories[i + 1]) + 1;
                cursorLeft += longestName+3;
            }

        }

        static void Main(string[] args)
        {
            DirectoryTree(@"C:\Program Files\HP\Documentation");
            Console.ReadKey();
        }
    }
}
