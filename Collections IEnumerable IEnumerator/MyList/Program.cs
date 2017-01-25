using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main()
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            Console.WriteLine("Arrey Length = {0}", list.Count);

            foreach (int item in list)
                Console.Write("{0}  ", item);

            // Delay.
            Console.ReadKey();
        }
    }
}
