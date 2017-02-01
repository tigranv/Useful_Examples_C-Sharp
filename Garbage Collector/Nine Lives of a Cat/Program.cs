using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nine_Lives_of_a_Cat
{
    class Cat
    {
        ~Cat()
        {
            Console.WriteLine($"Finaliser {Program.counter++}");
            Program.Instance = this;

            if (Program.counter < 9)
                GC.ReRegisterForFinalize(this);
        }
    }
    class Program
    {
        public static Cat Instance { get; set; }
        public static int counter;

        static void Main(string[] args)
        {
            // new Cat
            Instance = new Cat();

            // Killing cut
            Instance = null;


            
        }
    }
}
