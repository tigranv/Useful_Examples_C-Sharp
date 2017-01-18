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
            Console.WriteLine("Enter new file name");
            string fileName = Console.ReadLine();
            string path = @"C:\Users\Tigran PC\Desktop\TestDirectory\" + fileName+".txt";

            try
            {

                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

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
