# Reflection  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

[**Reflection**] (https://msdn.microsoft.com/en-us/library/mt656691.aspx) provides objects (of type Type) that describe assemblies, modules and types. You can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties. If you are using [attributes] (https://msdn.microsoft.com/en-us/library/5x6cd29c.aspx) in your code, reflection enables you to access them.


> Reflection is useful in the following situations:

* When you have to access attributes in your program's metadata.

* For examining and instantiating types in an assembly.

* For building new types at runtime. Use classes in System.Reflection.Emit.

* For performing late binding, accessing methods on types created at run time.


> **Example of loading assembly and getting anformation about**

```c#
using System;
using System.IO;
using System.Reflection; // using Reflection

// To test this You need
// Copy the dll file from previous project` CarLibrary.dll to the file where  LoadAssembly.exe file is

namespace LoadAssembly
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 50);

            // With class Assembly - it is possible to load dll-s dynamicly, 
            // Organising Late Binding, and getting information about Assembly
            Assembly assembly = null;

            try
            {
                // Assembly.Load() - Method for loading Assembly.
                assembly = Assembly.Load("CarLibrary"); // It is also possible to use Method LoadFrom( Assembly path)
                Console.WriteLine("Ñáîðêà CarLibrary - óñïåøíî çàãðóæåíà.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Info about all types, members and parameters in Assembly.
            ListAllTypes(assembly);
            ListAllMembers(assembly);
            GetParams(assembly);

            Console.ReadKey();
        }

        private static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Console.WriteLine("\ntypes in: {0} \n", assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type t in types)
                Console.WriteLine("Type: {0}", t);
        }

        private static void ListAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            Type type = assembly.GetType("CarLibrary.MiniVan");

            Console.WriteLine("\nClass Members: {0} \n", type);

            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo element in members)
                Console.WriteLine("{0,-15}:  {1}", element.MemberType, element);
        }

        private static void GetParams(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            Type type = assembly.GetType("CarLibrary.MiniVan");
            MethodInfo method = type.GetMethod("Driver"); // Equals , Acceleration, Driver

            Console.WriteLine("\nInfo about parameters of method {0}", method.Name);
            ParameterInfo[] parameters = method.GetParameters();
            Console.WriteLine("Method have" + parameters.Length + " parameters");

            foreach (ParameterInfo parameter in parameters)
            {
                Console.WriteLine("Parameter name: {0}", parameter.Name);
                Console.WriteLine("position in method: {0}", parameter.Position);
                Console.WriteLine("Parameter Type: {0}", parameter.ParameterType);
            }

        }
    }
}
```


> **Example of Late Binding by Object**]

```c#
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
```

> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
