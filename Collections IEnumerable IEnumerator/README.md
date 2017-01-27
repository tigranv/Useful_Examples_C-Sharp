# User Collections IEnumerable, IEnumerator  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 

### [MyList] (https://github.com/tigranv/Useful-examples/blob/master/Collections%20IEnumerable%20IEnumerator/MyList/MyList.cs) is a my analogy of class List<T>

> Example of using

```c#
class Program
{
    static void Main()
    {
        MyList<int> list = new MyList<int>();
        for (int i = 0; i < 5; i++)
            list.Add(i);

        Console.WriteLine("Arrey Length = {0}", list.Count);

        foreach (int item in list)
            Console.Write("{0}  ", item);

        // Delay.
        Console.ReadKey();
    }
}
```


### [MyDictionary] (https://github.com/tigranv/Useful-examples/blob/master/Collections%20IEnumerable%20IEnumerator/MyDictionary/MyDictionary.cs) is a my analogy of class Dictionary<T>

> Example of using

```c#
class Program
{
    static void Main()
    {
        var dictionary = new MyDictionary<string, string>(5);

        dictionary.Add(0, "սեղան", "table");
        dictionary.Add(1, "խնձոր", "aplle");
        dictionary.Add(2, "մատիտ", "pencil");
        dictionary.Add(3, "արև", "sun");
        dictionary.Add(4, "գիրք", "book");

        foreach (var item in dictionary)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("second note in dictionary:");
        Console.WriteLine(dictionary[1]);
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Length of dictionary:");
        Console.WriteLine(dictionary.Lenght + " words");
        Console.WriteLine(new string('-', 50));

        // Delay.
        Console.ReadKey();
    }
}
```

### [GetArrayExtention] (https://github.com/tigranv/Useful-examples/tree/master/Collections%20IEnumerable%20IEnumerator/GetArrayExtention) is extention method for IEnumerable<T>, that converts list to array.

> Example of using

```c#
static void Main()
{

    MyList<int> list = new MyList<int>();

    for (int i = 0; i < 8; i++)
        list.Add(i);

    int[] arr = list.GetArray();

    foreach (int t in arr)
        Console.Write("{0}  ", t);

    // Delay.
    Console.ReadKey();
}
```

> Projects written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
