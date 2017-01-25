using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ReturnEvenCollection
{
    class Program
    {
        static IEnumerable FindEven(int[] arr)
        {
            if (arr.Length != 0)
            {
                foreach (var item in arr)
                if (item%2 == 0)  yield return item;

            }
            else
            {
                yield break;
            }
        }


        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 15, 41, 20, 87, 6, 9, 8, 3, 7,  };
            IEnumerable res = FindEven(array);
            foreach (int elem in res)
                Console.Write("{0}  ", elem);
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
