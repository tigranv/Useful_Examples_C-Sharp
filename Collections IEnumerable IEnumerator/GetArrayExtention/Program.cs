using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArrayExtention
{
    static class StaticClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];

            int i = 0;

            foreach (T item in list)
            {
                array[i] = item;
                i++;
            }

            return array;
        }
    }

    class Program
    {
        static void Main()
        {

            MyList<int> list = new MyList<int>();

            for (int i = 0; i < 8; i++)
                list.Add(i);

            int[] arr = list.GetArray();

            foreach (int t in arr)
                Console.Write("{0}  ", t);

            // Delay.
            Console.ReadKey();
        }
    }
}
