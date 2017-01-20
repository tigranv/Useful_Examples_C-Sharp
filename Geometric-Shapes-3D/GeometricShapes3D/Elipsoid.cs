using System;

namespace GeometricShapes3D
{
    public class Ellipsoid : Shape3D, IChangeable
    {
        //constructor
        public Ellipsoid(Point3D location, float a, float b, float c) : base(location)
        {
            R1 = a;
            R2 = b;
            R3 = c;
        }

        //Radiuses
        protected float R1;
        protected float R2;
        protected float R3;

        public override float SurfaceArea
        {
            get
            {
                return (float)(4 * Math.PI * Math.Pow((Math.Pow(R1 * R2, 1.6) + Math.Pow(R1 * R3, 1.6) + Math.Pow(R2 * R3, 1.6)) / 3, 1 / 1.6));

            }
        }

        public override float ShapeVolume
        {
            get
            {
                return 4 / 3 * (float)(Math.PI * R1 * R2 * R3);
            }
        }

        public void ChangeSizeies(float a, float b, float c)
        {
            R1 = a;
            R2 = b;
            R3 = c;
        }
    }
}
