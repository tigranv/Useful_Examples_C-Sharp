# Geometric-Shapes-3D Example Of Using Interfacies <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

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

