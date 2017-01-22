using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral_Calculator
{



    class Program
    {
        // Delegat that takes function with return type double and 1 double argument 
        delegate double MyDelegate(double x);

        // Finction that will be sended with delegat
        static double MyFunction(double x)
        {
            return Math.Exp(x) + Math.Log10(x);
        }


        // Function for integral calculation , which takes delegate as argument
        static double Integrate(MyDelegate f,  double x1, double x2, Integration_Accuracy a)
        {
            int accuracy = 0;
            switch (a)
            {
                case Integration_Accuracy.Accuracy1:
                    accuracy = 10;
                    break;
                case Integration_Accuracy.Accuracy2:
                    accuracy = 100;
                    break;
                case Integration_Accuracy.Accuracy3:
                    accuracy = 10000;
                    break;
                case Integration_Accuracy.Accuracy4:
                    accuracy = 1000000;
                    break;
            }

            double h = (x2 - x1) / accuracy;
            double res = (f(x1) + f(x2)) / 2;
            for (int i = 1; i < accuracy; i++)
            {
                res += f(x1 + i * h);
            }
            return h * res;
        }

        static void Main(string[] args)
        {
            MyDelegate Fx = MyFunction;

            double resut = Integrate(Math.Sin, 0, Math.PI, Integration_Accuracy.Accuracy2);

            Console.WriteLine(resut);

            Console.ReadKey();
        }
    }
}
