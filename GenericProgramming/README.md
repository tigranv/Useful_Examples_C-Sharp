# Generic Programming/  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 

Generic classes and methods combine reusability, type safety and efficiency in a way that their non-generic counterparts cannot. You can create custom generic types and methods to provide your own generalized solutions and design patterns that are type-safe and efficient.


[ClassFactory] is a (https://github.com/tigranv/Useful-examples/tree/master/GenericProgramming/ClassFactory) example of Generic Method, that generates classes 


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

[MyList] is a (https://github.com/tigranv/Useful-examples/tree/master/GenericProgramming/MyList) analogy of List<> with following methods *Add, Count, Clear, Contains, ToString*



** Using **

```c#
static class Program
{
    static void Main()
    {
        // Methods Add, Count, Clear, Contains

        Console.WriteLine("Enter list size");
        string str = Console.ReadLine();
        int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

        var list = new MyList<int>();

        var t = new Random();
        for (int x = 0; x < u; x++)
        {
            list.Add(t.Next(100));
        }

        Console.WriteLine("Elements of list are");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));

        //foreach (var item in list)  //is not working , no getenumerator
        //{

        //}

        Console.WriteLine("Enter searching number");
        if (list.Contains(Convert.ToInt32(Console.ReadLine())))
        {
            Console.WriteLine("List contains this number");
        }
        else
        {
            Console.WriteLine("no matchies");
        }


        var arr = list.GetArray();

        foreach (var item in arr) // working because GetArray returns Array tape
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

    public static T[] GetArray<T>(this MyList<T> list)
    {
        var temp = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            temp[i] = list[i];
        }
        return temp;
    }
}

```

> Projects written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
