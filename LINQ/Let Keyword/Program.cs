using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_Keyword
{
    class Program
    {
        static void Main()
        {
            // Let creates local variable, that can be used only in expretion
            var query = from x in Enumerable.Range(0, 10)
                        let innerRange = Enumerable.Range(0, 10)
                        from y in innerRange
                        select new { X = x, Y = y, Product = x * y };

            foreach (var item in query)
                Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);

            // Delay.
            Console.ReadKey();
        }
    }
}
