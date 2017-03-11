# Attributes  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 


C# provides a mechanism for defining declarative tags, called [**Attributes**] (https://msdn.microsoft.com/en-us/library/aa287992(v=vs.71).aspx), which you can place on certain entities in your source code to specify additional information. The information that attributes contain can be retrieved at run time through reflection. You can use predefined attributes or you can define your own custom attributes

> Example usage of attributes includes:

* Associating help documentation with program entities (through a Help attribute).
* Associating value editors to a specific type in a GUI framework (through a ValueEditor attribute).

**Declaring an Attribute Class** in C# is simple — it takes the form of a class declaration that inherits from System.Attribute and has been marked with the AttributeUsage attribute as shown below:

```c#

namespace Create_Attribute
{
    // it is nessesary to inherit from System.Attribute

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]

    class MyAttribute : System.Attribute
    {
        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        public MyAttribute(string date)
        {
            this.date = date;
        }

        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
```
Once the attribute has been created, you then associate the attribute with a particular program element. 

```c#
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
```

Once the attribute has been associated with a program element, you use reflection to query its existence and its value.

```c#
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
```

### Conditional and Obsolete Attributes

**Conditional** Attribute Makes the execution of a method dependent on a preprocessing identifier. The Conditional attribute is an alias for *ConditionalAttribute*, and can be applied to a method or an attribute class.

The **Obsolete** attribute marks a program entity as one that is no longer recommended for use. Each use of an entity marked obsolete will subsequently generate a warning or an error, depending on how the attribute is configured.

```c#
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
```


> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
