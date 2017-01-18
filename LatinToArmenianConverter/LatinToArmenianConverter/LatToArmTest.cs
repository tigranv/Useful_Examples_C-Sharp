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
            //StreamReader sr = File.OpenText(@"C:\Users\Tigran PC\Desktop\TestDirectory\Necessary1.txt");
            //string armenian = sr.ReadLine();
            Console.WriteLine(armenian.LatToArmConverter());

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }       
    }
}
