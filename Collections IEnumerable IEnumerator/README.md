# User Collections IEnumerable, IEnumerator  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 

It is a best practice to implement **IEnumerable** and **IEnumerator** on your collection classes to enable the foreach syntax, however implementing IEnumerable is not required. If your collection does not implement IEnumerable, you must still follow the iterator pattern to support this syntax by providing a GetEnumerator method that returns an interface, class or struct. You must provide a class that contains a Current property, and MoveNext and Reset methods as described by IEnumerator, but the class does not have to implement IEnumerator.

> **Foreach: how it works**


```c#

UserCollection myElementsCollection = new UserCollection(); // consists of elements

//UpCast to IEnumerable
IEnumerable enumerable = myElementsCollection as IEnumerable;

// Get iterator(enumerator) from enumerable by calling method`  GetEnumerator().            
IEnumerator enumerator = enumerable.GetEnumerator();

// Use methods of IEnumerable
while (enumerator.MoveNext())
{
    Element item = enumerator.Current as Element; // DownCast to type of enement
    // using item
}

```

> Where  methods and property of IEnumerable  and IEnumerator is


```c#
class UserCollection : IEnumerable  // inherits from IEnumerable  and IEnumerator
{

public Element[] elementsArray = null;

public UserCollection()
{
    elementsArray = new Element[2];
    elementsArray[0] = new Element("A", 1, 10);
    elementsArray[1] = new Element("B", 2, 20);
}

// implimentation of interfaces

public bool MoveNext()
{
    if (position < elementsArray.Length - 1)
    {
        position++;
        return true;
    }
    else
    {
        return false;
    }
}


public void Reset()
{
    position = -1;
}


public object Current
{
    get { return elementsArray[position]; }
}


IEnumerator IEnumerable.GetEnumerator()
{
    return this as IEnumerator;
}
```


> In case of Yield

```c#
 public class UserCollection : IEnumerable  // inherits only from IEnumerable 
    {
        public Element[] elementsArray = null;

        public UserCollection()
        {
            elementsArray = new Element[2];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
        }


        int position = -1;

        public void Reset()
        {
            position = -1;
        }

        // -------------------------------------------------------------------------------------------------------------------------
        // yield creats all methods and returns collection IEnumerator

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < elementsArray.Length - 1)
                {
                    position++;
                    yield return elementsArray[position];
                }
                else
                {
                    Reset();
                    yield break;  // Âûõîä èç öèêëà.       
                }
            }
        }
```


### Examples of using IEnumerable  and IEnumerator

> [**MyList**] (https://github.com/tigranv/Useful-examples/blob/master/Collections%20IEnumerable%20IEnumerator/MyList/MyList.cs) is an analogy of class List<T> 

```c#
    class MyList<T>
    {
        T[] array = null;

        public MyList()
        {
            array = new T[0];
        }

        public int Count
        {
            get { return array.Length; }
        }

        public void Add(T elem)
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0);
            arr[array.Length] = elem;
            array = arr;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        int position = -1;

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
    }
```

> **GetArrayExtention** - Extention method for generic IEnumerable, that converts list to array.


```c#
public static T[] GetArray<T>(this IEnumerable<T> list)
{
    T[] array = new T[list.Count()];

    int i = 0;

    foreach (T item in list)
    {
        array[i] = item;
        i++;
    }

    return array;
}
```

> **FindEven** - Extention method that returns IEnumerable collection from int array

```c#
static IEnumerable FindEven(int[] arr)
{
    if (arr.Length != 0)
    {
        foreach (var item in arr)
        if (item%2 == 0)  yield return item;

    }
    else
    {
        yield break;
    }
}
```
 
 
 
 
 
> Projects written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
