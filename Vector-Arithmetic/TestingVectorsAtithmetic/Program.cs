using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorArithmetic;

namespace TestingVectorsAtithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector A = new Vector(5, 9);
            Vector B = new Vector(8, 11);

            Vector result = 2 * B + A * 7 - B;
            Console.WriteLine("Length of new vector is (2 * B + A * 7 - B)  is equals to {0}", result.length);

            Console.ReadKey();
        }
    }
}
