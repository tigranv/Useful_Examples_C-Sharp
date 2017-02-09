# Working with Indexers  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

**Indexers Overview**

* Indexers enable objects to be indexed in a similar manner to arrays.

* A **get** accessor returns a value. A set accessor assigns a value.

* The **this** keyword is used to define the indexers.

* The **value** keyword is used to define the value being assigned by the set indexer.

* Indexers do not have to be indexed by an integer value; it is up to you how to define the specific look-up mechanism.

* Indexers can be overloaded.

* Indexers can have more than one formal parameter, for example, when accessing a two-dimensional array.

### Galaxy Solar System is an example of using indexers by number and name.

Let's create new solar system using class **NewGalaxy**                 
Select the galaxy, sun(from Galaxy and Sun enumerations) and the number of planets.

```c#
NewGalaxy Galaxy1 = new NewGalaxy(Galaxy.Andromeda, Sun.Sirius, 4);
```

Choose your planets names using **indexer by planet numbers** and select planets from Planets enumeration
```c#
Galaxy1[0] = (Planets)1;
Galaxy1[1] = (Planets)12;
Galaxy1[2] = Planets.Venus;
Galaxy1[3] = Planets.Aquarii;
```

Choose positions for your planets using **indexer by planets names**
```c#
Galaxy1[Planets.Venus] = 0;
Galaxy1[Planets.Aquarii] = 1;
Galaxy1[Planets.Jupiter] = 2;
Galaxy1[Planets.Proxima] = 3;
```
Use methhod **GetInfo** for base information about your galaxy and sun.             
Getting information about positions of planets organised as follows(**indexer by numbers used in indexer by names**)
```C#
for (int i = 0; i < Galaxy1.Numberofplanets; i++)
            {
                for (int j = 0; j < Galaxy1.Numberofplanets; j++)
                {
                    if(Galaxy1[Galaxy1[j]]==i)
                    {
                        Console.ForegroundColor = (ConsoleColor)i+1;
                        Console.Write("------>{0}", Galaxy1[j]);
                        break;
                    }
                }           
            }
```

> The output is the full information about your Solar system

![Output] (https://cloud.githubusercontent.com/assets/24522089/21958406/df04d260-dac6-11e6-9773-189126c50797.PNG)

>Here are the codes of indexers

```C#
// Indexer by planets numbers for names
public Planets this[int index]
{
get
{
    if (index >= 0 && index < numberofplanets)
        return planets[index];
    else throw new ArgumentOutOfRangeException();
}
set
{

    if (index >= 0 && index < numberofplanets)
        planets[index] = (Planets)value;
    else throw new ArgumentOutOfRangeException();
}
}

// Indexer by planets names, for position
public int this[Planets index]
{
get
{
    for (int i = 0; i < planets.Length; i++)
        if (planets[i] == index) return position[i];
    throw new ArgumentOutOfRangeException();
}
set
{
    int indicate = 0;
    for (int i = 0; i < planets.Length; i++)
        if (planets[i] == index) { position[i] = value; indicate++; }
    if(indicate == 0) throw new ArgumentOutOfRangeException();
}
}
```


### Fibonacci calculator is a  simple example of using indexer

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
