using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GC_Generations
{
    class Program
    {
        static void Main()
        {
            Thread.Sleep(4000);
            // Method GetTotalMemory() heap memory in bytes
            // if true - run GC, if false without running
            Console.WriteLine("memory in heap {0}", GC.GetTotalMemory(false));

            // get max number of generations in system
            Console.WriteLine("heap have {0} generation\n", (GC.MaxGeneration + 1));

            // creating new object in heap.
            Car car = new Car("RENAULT", 120);

            Console.WriteLine(car.ToString());

            // GetGeneration() gives the generation where our object
            Console.WriteLine("\nObject car in {0} generation\n", GC.GetGeneration(car));

            Console.WriteLine("Size of memeory in heap {0}", GC.GetTotalMemory(false));

            // Array of objects for testing
            object[] array = new object[10000000];

            ShowGCStat();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new object();
            }

            Console.WriteLine("size of heap {0}", GC.GetTotalMemory(false));
            array = null;

            Console.WriteLine("\nstart  GC ");

            ShowGCStat();
            var start = DateTime.Now;
            // Collect - check generation .            
            GC.Collect();

            // Метод WaitForPendingFinalizers() - stops thread, while finilaser will work
            // calls after  GC.Collect().
            GC.WaitForPendingFinalizers();

            Console.WriteLine("GC worked                  " + (DateTime.Now - start).TotalMilliseconds + "\n");

            Console.WriteLine("size of memeory {0}", GC.GetTotalMemory(false));

            Console.WriteLine("\nObject car in {0} generation.\n", GC.GetGeneration(car));

            // Метод CollectionCount() - how much checked this object

            ShowGCStat();

            
            Console.ReadKey();
        }

        private static void ShowGCStat()
        {
            Console.WriteLine("\ngeneration 0 checked {0} times", GC.CollectionCount(0));
            Console.WriteLine("generation 0 checked {0} times", GC.CollectionCount(1));
            Console.WriteLine("generation 0 checked {0} times", GC.CollectionCount(2));
        }
    }
}
