  
Simple example of using indexer

# Fibonacci calculator  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

> Class Fibonacci

```c#
public class Fibonacci
{
    public Fibonacci(int l)
    {
        if(l>16 || l<0) throw new ArgumentOutOfRangeException();
        length = l;
        Fibonac = new int[l];
        Fibonac[0] = 0;
        Fibonac[1] = 1;
        for (int i = 2; i < l; i++)
        {
            Fibonac[i] = Fibonac[i - 1] + Fibonac[i - 2];
        }
    }

    private int[] Fibonac;
    private int length;

    public int this[int index]
    {
        get
        {              
            if (index >=0 && index <= length) return Fibonac[index];
            throw new ArgumentOutOfRangeException();
        }
    }

}
```

> Using

```c#
class Program
  {
      static void Main(string[] args)
      {
          // new Fibonacci series
          Fibonacci NewFibonacci = new Fibonacci(10);
          // get 5th member of series
          Console.WriteLine(NewFibonacci[9]);
          Console.ReadKey();
      }
  }
```

> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition



