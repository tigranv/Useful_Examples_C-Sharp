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
