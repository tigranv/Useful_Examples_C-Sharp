using System;
using System.Linq;
using System.IO;

namespace Directory_Tree
{
    class Program
    {
        public static void DirectoryTree(string fullPath)
        {
            string[] directories = fullPath.Split('\\');
            string subPath = "";
            int cursorUp = 0;
            int cursorLeft = 0;

            for (int i = 0; i < directories.Length - 1; i++)
            {
                subPath += directories[i] + @"\";
                DirectoryInfo dir = new DirectoryInfo(subPath);
                //var files = directory.GetFiles().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden)).ToArray();
                //var folders = directory.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden)).ToArray();

                var folders = Directory.GetDirectories(subPath).Select(Path.GetFileName).ToArray();
                string[] files = dir.GetFiles().Select(o => o.Name).ToArray();
                int j = 0;
                // int longestFolder = (folders).Where(s => s.Length == folders.Max(m => m.Length)).First().Length;
                // int longestFle = (files).Where(s => s.Length == files.Max(m => m.Length)).First().Length;
                int longestName = 25; //(longestFolder <= longestFle ? longestFle:longestFolder)<=25? (longestFolder <= longestFle ? longestFle : longestFolder) : 26;

                for (int k = 0; k < folders.Length; k++)
                {
                    folders[k] = folders[k].Length <= 25 ? folders[k] : (folders[k].Substring(0, 22) + "...");

                    if (folders[k] != directories[i + 1])
                    {
                        Console.SetCursorPosition(cursorLeft, cursorUp + j);
                        Console.WriteLine("+" + folders[k]);
                        j++;
                    }
                    else
                    {
                        

                        if (i != directories.Length - 2)
                        {
                            Console.SetCursorPosition(cursorLeft, cursorUp + j);
                            Console.WriteLine("-" + folders[k] + new string('-', longestName - directories[i + 1].Length) + "\u261B");
                            j++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(cursorLeft, cursorUp + j);
                            Console.WriteLine("***"+ folders[k] + "***");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            j++;
                        }
                    }
                }

                for(int k = 0; k <  files.Length; k++)
                {
                    files[k] = files[k].Length <= 25 ? files[k] : (files[k].Substring(0, 22) + "...");
                    Console.SetCursorPosition(cursorLeft, cursorUp + j);
                    Console.WriteLine("+" + files[k]);
                    j++;
                }

                cursorUp += Array.IndexOf(folders, directories[i + 1]) + 1;
                cursorLeft += longestName+3;
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DirectoryTree(@"C:\Program Files\HP\Documentation");
            Console.ReadKey();
        }
    }
}
