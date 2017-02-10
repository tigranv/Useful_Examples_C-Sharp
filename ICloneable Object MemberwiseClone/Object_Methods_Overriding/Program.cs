using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods_Overriding
{
    class Program
    {
        static void Main()
        {
            // creating 2 boxes
            Box box1 = new Box(7, 12, 7);
            Box box2 = new Box(7, 12, 7);

            //box1 = box2;
            Console.WriteLine(box1.ToString()+"\n");
            Console.WriteLine(box2.ToString());

            Console.WriteLine(new string(' ', 30));

            Console.WriteLine("box1 equals to box2 = {0} \n", box1.Equals(box2));

            Console.WriteLine(box1.GetHashCode() == box2.GetHashCode() ? "hash Codes are equal" : "Hash Codes are different");
            Console.WriteLine(box1.GetHashCode());
            Console.WriteLine(box2.GetHashCode());

            // Delay.
            Console.ReadKey();
        }
    }
}
