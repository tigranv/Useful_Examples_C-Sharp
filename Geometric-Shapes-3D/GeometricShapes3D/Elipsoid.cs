using System;

namespace GeometricShapes3D
{
    public class Elipsoid : Shape3D
    {
        public Elipsoid(float x, float y, float z)
        {
            if ((x <= 0) || (y <= 0) || (z <= 0)) { throw new ArgumentOutOfRangeException("Not real parameter"); }
            base.x = x;
            base.y = y;
            base.z = z;
        }

        public override float SurfaceArea()
        {
            return (float)(4 * Math.PI * Math.Pow((Math.Pow(x * y, 1.6) + Math.Pow(x * z, 1.6) + Math.Pow(y * z, 1.6)) / 3, 1 / 1.6));
        }

        public override float Volume()
        {
            return 4 / 3 * (float)(Math.PI * x * y * z);
        }
    }
}
