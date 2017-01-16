using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinToArmenianConverter
{
    static class LatToArm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Մուտքագրեք լատինատառ արտահայտություն");
            string armenian = Console.ReadLine();
            Console.WriteLine(armenian.LatToArmConverter());
            

            Console.ReadKey();

        }
    }
}
