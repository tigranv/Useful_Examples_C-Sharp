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
            Program.counter++;
            if (Program.counter < 10) Console.WriteLine($"Killing cat!!!");
            Program.Instance = this;

            if (Program.counter < 9)
            {
                Console.WriteLine($"Myauuu , it was my {Program.counter} live");
                GC.ReRegisterForFinalize(this);
            }

            if (Program.counter == 9)
            {
                Console.WriteLine($"MyauuuVaaaaax it was my {Program.counter} live, You Killed Me Completely ");
                GC.ReRegisterForFinalize(this);
            }

        }
    }
    class Program
    {
        public static Cat Instance { get; set; }
        public static int counter = 0;

        static void Main(string[] args)
        {
            // new Cat
            Instance = new Cat();

            Instance = null; // Killing cut 1 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 2 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 3 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 4 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 5 time
            GC.Collect();

            Instance = null; // Killing cut 6 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 7 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 8 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 9 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 1st time
            GC.Collect();
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
