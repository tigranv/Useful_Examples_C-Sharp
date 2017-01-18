using System;
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

                //Create the file.
                FileStream fs = File.Create(path);
                fs.Close();
                //Write in file.
                StreamWriter sw = new StreamWriter(path);      
                sw.WriteLineAsync("Some text");
                sw.Close();
                //read from file.
                StreamReader sr = File.OpenText(path);
                string textline = sr.ReadLine();
                Console.WriteLine(textline);
                sr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
