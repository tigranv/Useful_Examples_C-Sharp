using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kill_Unnecessary_Files_
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktop, "TestDirectory");
            Console.WriteLine("Do You really want to clean directory? Yes or No");
            if(Console.ReadLine() == "Yes")
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    switch (file.Name)
                    {
                        case "Necessary1.txt":
                            break;
                        case "Necessary2.txt":
                            break;
                        case "Necessary3.txt":
                            break;
                        case "Kill Unnecessary Files!.exe":
                            break;
                        default:
                            file.Delete();
                            break;
                    }
                }
            }
            
            
        }
    }
}
