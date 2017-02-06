# Vector-Arithmetic. Example of using operators overloading <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

Operator overloading permits user-defined operator implementations to be specified for operations where one or both of the operands are of a user-defined class or struct type.(by defining static member functions using the operator keyword) The folowing operators can be overloaded`


> Unary operators +, -, !, ~, ++, --, true, false

> Binary operators +, -, *, /, %, &, |, ^, <<, >>

> Comparison operators  ==, !=, <, >, <=, >=


__Vector-Arithmetic__ example represents vectors and basic operations applyed on them. Project includes operations of adding, subtracting, scalar multiplication, multiplication by number.

> overloading of plus operator

```c#
public static Vector operator +(Vector a, Vector b)
{
    return new Vector(a.end.x + b.end.x, a.end.y + b.end.y);
}
```

### Testing

```c#
 static void Main(string[] args)
        {
            Vector A = new Vector(5, 9);
            Vector B = new Vector(8, 11);

            Vector result = 2 * B + A * 7 - B;
            Console.WriteLine("Length of new vector is (2 * B + A * 7 - B)  is equals to {0}", result.length);

            Console.ReadKey();
        }
```

**The Output is**   --> *Length of new vector is (2 * B + A * 7 - B)  is equals to 85.5862138431184*


> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
