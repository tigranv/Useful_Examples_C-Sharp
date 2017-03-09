using System;
using System.Reflection;

namespace Create_Attribute
{
    // Class myClass have attribute Myattribute, and method also have attribute
    // the first prop is constructor variables, second is attribute auto properties

    // [My("1/31/2008", Number = 1)] error adding 2 attributes, ->    AllowMultiple = false

    [My("1/31/2008", Number = 1)] // attribute of class
    public class MyClass
    {
        [MyAttribute("2/31/2007", Number = 2)] // attribute of method
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()\n");
        }
    }


    class Program
    {
        static void Main()
        {
            // instance of MyClass
            MyClass my = new MyClass();
            MyClass.Method();

            // Analising the attributes if type.

            Type type = typeof(MyClass);
            object[] attributes = null;

            MyAttribute attribute = null;


            // Getting all attributes of type MyClass (false - dont show base class attributes).
            attributes = type.GetCustomAttributes(false);

            foreach (object attributeType in attributes)
            {
                attribute = attributeType as MyAttribute;
                Console.WriteLine("Type Analising  : Number = {0}, Date = {1}", attribute.Number, attribute.Date);
            }


            // Attribute analising.

            // getting method ( public and static ) - Method. using reflection
            MethodInfo method = type.GetMethod("Method", BindingFlags.Public | BindingFlags.Static);

            // Getting all attributes of method (false - dont show base class attributes).
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
