using System;
using System.IO;
using System.Reflection;

namespace LateBinding_Object
{
    class Program
    {
        static void Main()
        {
            // See example Load Assembly
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            // Creating "Late Binding" instance of class MiniVan from assembly CarLibrary 
            // By using class Activator.
            // Method CreateInstance() - Creates an instance of the specified type using that type's default constructor..
            Type type = assembly.GetType("CarLibrary.MiniVan");

            object instance = Activator.CreateInstance(type); // is late Bonding, early binding is when we use "new Minivan()"

            // Getting instance of class MethodInfo for method Acceleration(). 
            MethodInfo method = type.GetMethod("Acceleration");

            // Calling method Acceleration().
            // first parameter - reference to an instance which contains method  Acceleration
            // second parameter - an array of arguments of method  Acceleration - (in this case)null)
            method.Invoke(instance, null);

            // getting instance of class MethodInfo for method Driver(). 
            method = type.GetMethod("Driver");

            // Array of parameters for Driver("Shumaher", 36). 
            object[] parameters = { "Shumaher", 36 };

            // Calling Driver().
            method.Invoke(instance, parameters);

            Console.ReadKey();
        }
    }
}
