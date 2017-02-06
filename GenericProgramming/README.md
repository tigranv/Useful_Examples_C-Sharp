# Generic Programming/  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 

Generic classes and methods combine reusability, type safety and efficiency in a way that their non-generic counterparts cannot. You can create custom generic types and methods to provide your own generalized solutions and design patterns that are type-safe and efficient.

> [ClassFactory] (https://github.com/tigranv/Useful-examples/tree/master/GenericProgramming/ClassFactory) example of Generic Method, that generates classes 

```c#
class MyClass<T> where T : new()
{
    public static T FacrotyMethod()
    {
        return new T();
    }
}

class Program
{
    static void Main()
    {
        int i = MyClass<int>.FacrotyMethod();

        Console.WriteLine(i.GetType().Name);

        Program p = MyClass<Program>.FacrotyMethod();

        Console.WriteLine(p.GetType().Name);

        Console.ReadKey();
    }
}
```




> Projects written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
