# User Collections IEnumerable, IEnumerator  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 

## [MyList] (https://github.com/tigranv/Useful-examples/tree/master/Collections%20IEnumerable%20IEnumerator/MyList) is a my analogy of class List<T>

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


## [MyList] () is a my analogy of class Divctionary<T>

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


> Projects written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
