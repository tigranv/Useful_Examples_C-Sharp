using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral_Calculator
{



    class Program
    {
        static double Integrate(Func<double, double> f, double x1, double x2)
        {
            double h = (x2 - x1) / 10000;
            double res = (f(x1) + f(x2)) / 2;
            for (int i = 1; i < 10000; i++)
            {
                res += f(x1 + i * h);
            }
            return h * res;
        }



        static void Main(string[] args)
        {

            double resut = Integrate(Math.Sin, 0, Math.PI);

            Console.WriteLine(resut);

            Console.ReadKey();
        }
    }
}
