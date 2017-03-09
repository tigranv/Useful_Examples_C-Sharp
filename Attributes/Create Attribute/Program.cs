using System;
using System.Reflection;

namespace Create_Attribute
{
    [My("1/31/2008", Number = 1)]
    public class MyClass
    {
        [MyAttribute("2/31/2007", Number = 2)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()\n");
        }
    }


    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            MyClass.Method();

            // Analising the attributes if type.

            Type type = typeof(MyClass);
            object[] attributes = null;

            MyAttribute attribute = null;


            // Getting all attributes of type MyAttribute (false - dont show base class attributes).
            attributes = type.GetCustomAttributes(false);

            foreach (object attributeType in attributes)
            {
                attribute = attributeType as MyAttribute;
                Console.WriteLine("Type Analising  : Number = {0}, Date = {1}", attribute.Number, attribute.Date);
            }


            // Attribute analising.

            // getting methods public and static - Method.
            MethodInfo method = type.GetMethod("Method", BindingFlags.Public | BindingFlags.Static);

            // Getting all attributes of type MyAttribute (false - dont show base class attributes).
            attributes = method.GetCustomAttributes(typeof(MyAttribute), false);

            foreach (MyAttribute attrib in attributes)
            {
                Console.WriteLine("Type Analising: Number = {0}, Date = {1}", attrib.Number, attrib.Date);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
