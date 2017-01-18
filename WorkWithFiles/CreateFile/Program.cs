using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateFile
{
    class Program
    {
        public static void Main()
        {
            string fileName;
            string path;

            try
            {
                do
                {
                    Console.WriteLine("Enter new file name -");
                    fileName = Console.ReadLine();
                    path = @"C:\Users\Tigran PC\Desktop\TestDirectory\" + fileName + ".txt";
                    if (File.Exists(path))
                    {
                        Console.WriteLine("The file with such a name is already exist, Do You wont to Replace it? ");
                        string key = Console.ReadLine();
                        if (key == "Yes")
                        {
                            File.Delete(path);
                        }
                    }
                    
                } while (File.Exists(path));

                // Create the file.
                FileStream fs = File.Create(path);     
                Byte[] info = new UTF8Encoding(true).GetBytes("Some text");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
                             
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
