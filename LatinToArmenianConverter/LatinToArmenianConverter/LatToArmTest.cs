using System;
using System.IO;

namespace LatinToArmenianConverter
{
    static class LatToArmTest
    {
        static void Main(string[] args)
        {
            // Հետևյալ տառերը ծրագիրը չի ներառում և փոխարինում է համապատասխանաբար՝ 
            // Է -> ե, թ -> տ, ռ -> ր, փ -> պ
        do
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Մուտքագրեք լատինատառ արտահայտություն");
            string armenian = Console.ReadLine();

            
            // // for translating files use this 
            //Console.WriteLine("Մուտքագրեք թարգմանվող ֆայլի հասցեն");
            //StreamReader sr = File.OpenText(@"C:\Users\Tigran PC\Desktop\TestDirectory\lattoarm.txt");
            //string armenian = "";
            //string arm = "";
            //while ((arm = sr.ReadLine()) != null)
            //{
            //    armenian+= arm+"\n";
            //}
 
            Console.WriteLine(armenian.LatToArmConverter());

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }       
    }
}
