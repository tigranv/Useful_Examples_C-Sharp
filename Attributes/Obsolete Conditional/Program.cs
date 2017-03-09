using System;
using System.Diagnostics;
using System.Reflection;

namespace Obsolete_Conditional
{
    [Obsolete("This is an old class. Use new class instead!")] // message for other usersof class.

    class Program
    {
        [Conditional("TRIAL")]
        void Trial()
        {
            Console.WriteLine("Trial version.");
        }

        [Conditional("PREMIUM")]
        void Release()
        {
            Console.WriteLine("Premium version.");
        }

#if DEBUG
        private void Initialize()
        {
            Console.WriteLine("initialising in mode DEBUG");
        }
#else
        private void Initialize()
        {
            Console.WriteLine("initialising in mode RELEASE");
        }
#endif

        static void Main()
        {
            var test = new Program();

            test.Initialize();
            test.Trial();   // Call only in TRIAL 
            test.Release(); // Call only in RELEASE 
            Console.WriteLine(new string('-', 20));

            Type type = typeof(Program);

            MethodInfo[] methodInfo = type.GetMethods(
                BindingFlags.Public |         // add in query public members. 
                BindingFlags.NonPublic |      // add in query non public members.
                BindingFlags.Instance |       
                BindingFlags.DeclaredOnly);  

            foreach (MethodInfo method in methodInfo)
            {
                Console.WriteLine(method.Name);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
