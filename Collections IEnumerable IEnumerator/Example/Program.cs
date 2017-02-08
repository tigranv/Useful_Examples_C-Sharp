using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection col = new Collection();

            foreach (var item in col)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
