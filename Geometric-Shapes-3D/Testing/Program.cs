using System;
using GeometricShapes3D;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Elipsoid elipsoid1 = new Elipsoid(3, 4, 8);
            Parallelogram paralelogram = new Parallelogram(2, 7, 15);

            Console.WriteLine("Surface area of elipsoid is {0}, and volume is {1}", elipsoid1.SurfaceArea(), elipsoid1.Volume());
            Console.WriteLine("Surface area of parallelogram is {0}, and volume is {1}", elipsoid1.SurfaceArea(), elipsoid1.Volume());

            Console.ReadKey();
        }
    }
}
