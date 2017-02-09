# Object Class, MemberwiseClone, IClonable  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

Working with Object class methods.

### [**Object Class**] (https://msdn.microsoft.com/en-us/library/system.object(v=vs.110).aspx) 

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes.
This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

| Method Name  | Description |
| -------------------------------------------------| ------------------------------------------------------------------------------- |
| **Equals**(Object)| (**virtual**) Determines whether the specified object is equal to the current object. | 
| **ToString**() | (**virtual**) Returns a string that represents the current object.| 
| **GetHashCode**() | (**virtual**) Serves as the default hash function.| 
| **GetType**() | (**virtual**) Gets the Type of the current instance. | 
| **MemberwiseClone**() | (**protected**) Creates a shallow copy of the current Object. | 
| **ReferenceEquals**(Object, Object) | (**static**) Determines whether the specified Object instances are the same instance.| 
| **Equals**(Object, Object) | (**static**) Determines whether the specified object instances are considered equal. | 
|  **Object**()| constructor. | 
| **~Object**()| (**protected**)Finalizer: Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. | 

### [MemberwiseClone] (https://msdn.microsoft.com/en-us/library/system.object.memberwiseclone(v=vs.110).aspx), [ICloneable] (https://msdn.microsoft.com/en-us/library/system.icloneable(v=vs.110).aspx) 

The **MemberwiseClone** method creates a shallow copy by creating a new object, and then copying the nonstatic fields of the current object to the new object. If a field is a value type, a bit-by-bit copy of the field is performed. If a field is a reference type, the reference is copied but the referred object is not; therefore, the original object and its clone refer to the same object.

> 

The **ICloneable** interface enables you to provide a customized implementation that creates a copy of an existing object. The ICloneable interface contains one member, the Clone method, which is intended to provide cloning support beyond that supplied by Object.MemberwiseClone. An implementation of Clone can perform either a deep copy or a shallow copy. In a deep copy, all objects are duplicated; in a shallow copy, only the top-level objects are duplicated and the lower levels contain references. 

### Examples

**MemberwiseClone, IClonable** is an example  of *Deep* and *Shallow* cloning

> **Testing result is**


> --> MemberwiseClone() method **does not using constructor** <--

Cloning With Constructor-         2536143 ticks

Cloning With MemberwiseClone-     2181 ticks

> -----> Example of **Shallow Cloning **<------

> Original

 Street is --> Kievyan
 
 City is --> Yerevan

> Original after changing

 Street is --> Rive
 
 City is --> Geneva

> Clone

 Street is --> Rive
 
 City is --> Yerevan


> -----> Example of **deep Cloning** <------

> Original

 Street is --> Kievyan
 
 City is --> Yerevan

> Original after changing

 Street is --> Rive
 
 City is --> Geneva

> Clone

 Street is --> Kievyan
 
 City is --> Yerevan



```c#
public class House 
{
    public Street street { get; set; }
    public string City { get; set; }

    public House(Street street, string City)
    {
        Thread.Sleep(1000); // to see that memberwiseClone is not calling constructor
        this.street = street;
        this.City = City;
    }

    // Shallow cloning using MemberwiseClone
    public object CloneWithMemberwise()
    {
        return MemberwiseClone() as House;
    }

    // Shallow cloning using Constructor
    public object CloneWithConstructor()
    {
        return new House(this.street, this.City);
    }

    public object DeepClone()
    {
        return new House(this.street.Clone() as Street, this.City);
        // // or in case if class Street dont have clone
        //House other = (House)this.MemberwiseClone();
        //other.street = new Street(street.Name);
        //other.City = String.Copy(City);
        //return other;
    }
}

public class Street :ICloneable
{
    public string Name { get; set; }

    public Street(string name)
    {
        Name = name;
    }

    // implimenting IClonable interface
    public object Clone()
    {
        return MemberwiseClone();
    }
}
```


**Object_Methods_Overriding** is an example  how you can override methods of object class

> We have class Box:

```c#
class Box
{
    public Box(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    private double sideA;
    private double sideB;
    private double sideC;

    public override bool Equals(object obj)
    {
        if(obj == null || this.GetType() != obj.GetType())
        return false;

        Box inst = obj as Box;
        return  (inst.sideA == sideA) && (inst.sideB == sideB) && (inst.sideC == sideC);
    }

    public override string ToString()
    {
        return $"Box with sizes A = {sideA}, B = {sideB}, C = {sideC}"; ;
    }

    public override int GetHashCode()
    {
        return (int)sideA ^ (int)sideB ^ (int)sideC;
    }
}
```

> Testing

```c#
static void Main()
{
    // creating 2 boxes
    Box box1 = new Box(15, 12, 5);
    Box box2 = new Box(7, 12, 5);

    Console.WriteLine(box1.ToString()+"\n");
    Console.WriteLine(box2.ToString());

    Console.WriteLine(new string(' ', 30));

    Console.WriteLine("box1 equals to box2 = {0} \n", box1.Equals(box2));

    Console.WriteLine(box1.GetHashCode() == box2.GetHashCode() ? "hash Codes are equal" : "Hash Codes are different");


    // Delay.
    Console.ReadKey();
}
```
> The output is:

>Box with sizes A = 15, B = 12, C = 5

>Box with sizes A = 7, B = 12, C = 5

>box1 equals to box2 = False

>Hash Codes are different







> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
