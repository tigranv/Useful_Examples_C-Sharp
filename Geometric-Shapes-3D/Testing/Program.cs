using System;
using GeometricShapes3D;

namespace Testing
{
    class Program
    {
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
    }
}
