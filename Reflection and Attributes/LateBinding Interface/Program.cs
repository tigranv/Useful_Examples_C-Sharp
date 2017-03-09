using System;
using System.IO;
using System.Reflection;
using CarLibrary;

// Late Binding is tecnology that provides - get types run time, get their names and properties run time.
// In early binding all this parts are done in compile time.

namespace LateBinding_Interface
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");

                Type type = assembly.GetType("CarLibrary.MiniVan");

                ICar carInstance = Activator.CreateInstance(type) as ICar;

                if (carInstance != null)
                {
                    carInstance.Acceleration();

                    carInstance.Driver("Shumaher", 26);
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }


        // Late Binding Dynamic

        //static void Main()
        //{
        //    Assembly assembly = null;

        //    try
        //    {
        //        assembly = Assembly.Load("CarLibrary");
        //        Type type = assembly.GetType("CarLibrary.MiniVan");

                  // dynamic instance 
        //        dynamic carInstance = Activator.CreateInstance(type);
        //        carInstance.Acceleration();
        //        carInstance.Driver("Shumaher", 26);
        //    }
        //    catch (FileNotFoundException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }


        //    Console.ReadKey();
        //}
    }
}
