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
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Tigran PC\Desktop\TestDirectory");

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
                    default:
                        file.Delete();
                        break;
                }                    
            }
        }
    }
}
