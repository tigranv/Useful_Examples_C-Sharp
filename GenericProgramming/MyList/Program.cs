using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    static class Program
    {
        static void Main()
        {
            // Methods Add, Count, Clear, Contains

            Console.WriteLine("Enter list size");
            string str = Console.ReadLine();
            int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new MyList<int>();

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(t.Next(100));
            }

            Console.WriteLine("Elements of list are");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //foreach (var item in list)  //is not working , no getenumerator
            //{

            //}

            Console.WriteLine("Enter searching number");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("List contains this number");
            }
            else
            {
                Console.WriteLine("no matchies");
            }


            var arr = list.GetArray();

            foreach (var item in arr) // working because GetArray returns Array tape
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static T[] GetArray<T>(this MyList<T> list)
        {
            var temp = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }
}
