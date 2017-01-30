using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Keyword
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // grouping
            var query = from x in numbers
                        group x by x % 3;

            foreach (var group in query)
            {
                Console.WriteLine("mod{0} == {0}", group.Key);

                foreach (var number in group)
                    Console.WriteLine("{0}, ", number);
            }

            // Delay.
            Console.ReadKey();
        }

        // see also INTO keyword

        //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var query = from x in numbers
        //            group x by x % 2 into partition
        //            where partition.Key == 0
        //            select new { Key = partition.Key, Count = partition.Count(), Group = partition };


        //    foreach (var item in query)
        //    {
        //        Console.WriteLine("mod2 == {0}", item.Key);
        //        Console.WriteLine("Count == {0}", item.Count);

        //        foreach (var number in item.Group)
        //            Console.Write("{0}, ", number);

        //        Console.WriteLine();
        //    }
}
}
