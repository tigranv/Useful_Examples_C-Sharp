﻿using System;

namespace LatinToArmenianConverter
{
    static class LatToArmTest
    {
        static void Main(string[] args)
        {
            // Հետևյալ տառերը ծրագիրը չի ներառում և պոխարինում է համապատասխանաբար՝ 
            // Է -> ե, թ -> տ, ռ -> ր, փ -> պ
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Մուտքագրեք լատինատառ արտահայտություն");
            string armenian = Console.ReadLine();
            Console.WriteLine(armenian.LatToArmConverter());

            //string a = "qwertyuiopasdfghjklzxcvbnm@&";
            //string st = Console.ReadLine();
            //bool b = a.Contains(st[4].ToString());
            //Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
