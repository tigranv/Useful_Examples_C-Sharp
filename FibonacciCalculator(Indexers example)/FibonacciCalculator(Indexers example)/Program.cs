using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCalculator_Indexers_example_
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Fibonacci series
            Fibonacci NewFibonacci = new Fibonacci(10);
            // get 5th member of series
            Console.WriteLine(NewFibonacci[9]);
            Console.ReadKey();
        }
    }
}
