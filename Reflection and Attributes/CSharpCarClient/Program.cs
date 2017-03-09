using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary; // Adding Class Library

namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is to show how to add Dll library usually
            // creating instance of sport car
            SportCar sportcar = new SportCar("Viper", 240, 40);
            sportcar.Acceleration();

            // creating instance of minivan
            MiniVan minivan = new MiniVan();
            minivan.Acceleration();

            // go to next project to see how we can use the same assembly using reflection methods
            Console.ReadKey();
        }
    }
}
