using System;

namespace Integral_Calculator
{
    // Delegat that takes function with return type double and 1 double argument 
    public delegate double MyDelegate(double x);
    // Instead of MyDelegate, we could use Func<double, double>

    class Program
    {
        // Finction that will be sended with delegat
        static double MyFunction(double x)
        {
            return Math.Exp(x) + Math.Log10(x);
        }

        static void Main(string[] args)
        {
            //giving pointer of MyFunction to MyDelegate 
            MyDelegate Fx = MyFunction;

            // Calling Integrate function from MathFunctions class and sending Myfunction with MyDelegate  to function Integrate 
            double MyFxResult = MathFunctions.Integrate(Fx, 0, 5, Integration_Accuracy.Accuracy2);

            // inegration of Sin function from 0 to Pi mut give 2, we use different accuracies to see the result
            double SinInteg1 = MathFunctions.Integrate(Math.Sin, 0, Math.PI, Integration_Accuracy.Accuracy1);
            double SinInteg2 = MathFunctions.Integrate(Math.Sin, 0, Math.PI, Integration_Accuracy.Accuracy2);
            double SinInteg3 = MathFunctions.Integrate(Math.Sin, 0, Math.PI, Integration_Accuracy.Accuracy3);
            double SinInteg4 = MathFunctions.Integrate(Math.Sin, 0, Math.PI, Integration_Accuracy.Accuracy4);

            Console.WriteLine($"Integral of Sin(x) from 0 to Pi in {1}- accuracy is {SinInteg1}");
            Console.WriteLine($"Integral of Sin(x) from 0 to Pi in {2}- accuracy is {SinInteg2}");
            Console.WriteLine($"Integral of Sin(x) from 0 to Pi in {3}- accuracy is {SinInteg3}");
            Console.WriteLine($"Integral of Sin(x) from 0 to Pi in {4}- accuracy is {SinInteg4}");

            Console.ReadKey();
        }
    }
}
