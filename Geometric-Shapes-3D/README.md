# Abstract Class,  Interfacies <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

An **interface** contains definitions for a group of related functionalities that a class or a struct can implement.
By using interfaces, you can, for example, include behavior from multiple sources in a class. That capability is important in C# because the language doesn't support multiple inheritance of classes. In addition, you must use an interface if you want to simulate inheritance for structs, because they can't actually inherit from another struct or class.

**Abstract classes** are closely related to interfaces. They are classes that cannot be instantiated, and are frequently either partially implemented, or not at all implemented. One key difference between abstract classes and interfaces is that a class may implement an unlimited number of interfaces, but may inherit from only one abstract (or any other kind of) class. A class that is derived from an abstract class may still implement interfaces. Abstract classes are useful when creating components because they allow you specify an invariant level of functionality in some methods, but leave the implementation of other methods until a specific implementation of that class is needed. They also version well, because if additional functionality is needed in derived classes, it can be added to the base class without breaking code.


### Geometric-Shapes-3D

Geometric-Shapes-3D is an example of using abstract class and interfaces

![shapes3d](https://cloud.githubusercontent.com/assets/24522089/22154134/c4504766-df43-11e6-8bf0-20dd4449a48d.PNG)

> Testing 

```c#
static void Main(string[] args)
        {
            Parallelepiped NewParalel = new Parallelepiped(new Point3D(0, 0, 0), 4, 7, 8, 40);
            Ellipsoid NewEllips = new Ellipsoid(new Point3D(1, 2, 4), 5, 2, 7);


            NewEllips.MoveToPoint(new Point3D(1, 1, 1));
            NewParalel.MoveToPoint(new Point3D(1, 1, 1));

            Console.WriteLine("Surface area of elipsoid is {0}, and volume is {1}", NewEllips.SurfaceArea, NewEllips.ShapeVolume);
            Console.WriteLine("Surface area of parallelogram is {0}, and volume is {1}", NewParalel.SurfaceArea, NewParalel.ShapeVolume);

            Console.ReadKey();
        }
```

> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition

