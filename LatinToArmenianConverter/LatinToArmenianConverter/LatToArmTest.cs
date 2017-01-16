using System;

namespace LatinToArmenianConverter
{
    static class LatToArmTest
    {
        static void Main(string[] args)
        {
            // Հետևյալ տառերը ծրագիրը չի ներառում և պոխարինում է համապատասխանաբար՝ 
            // Է -> ե, թ -> տ, ռ -> ր, փ -> պ

            Console.WriteLine("Մուտքագրեք լատինատառ արտահայտություն");
            string armenian = Console.ReadLine();
            Console.WriteLine(armenian.LatToArmConverter());
            
            Console.ReadKey();

        }
    }
}
