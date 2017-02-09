using System;

namespace Fibomacci_Calculator_Indexers_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Fibonacci series
            Fibonacci NewFibonacci = new Fibonacci(10);
            // get 6th member of series
            Console.WriteLine(NewFibonacci[6]);
            Console.ReadKey();
        }
    }
}
