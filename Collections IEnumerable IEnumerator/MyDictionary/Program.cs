using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main()
        {
            var dictionary = new MyDictionary<string, string>(5);

            dictionary.Add(0, "սեղան", "table");
            dictionary.Add(1, "խնձոր", "aplle");
            dictionary.Add(2, "մատիտ", "pencil");
            dictionary.Add(3, "արև", "sun");
            dictionary.Add(4, "գիրք", "book");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("second note in dictionary:");
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Length of dictionary:");
            Console.WriteLine(dictionary.Lenght + " words");
            Console.WriteLine(new string('-', 50));

            // Delay.
            Console.ReadKey();
        }
    }
}
