using System;

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
            Console.WriteLine(armenian.LatToArmConverter());

        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }       
    }
}
