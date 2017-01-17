
using System;

namespace GeometricShapes3D
{
    public class Parallelogram : Shape3D
    {
        public Parallelogram(float x, float y, float z)
        {
            if ((x <= 0) || (y <= 0) || (z <= 0)) { throw new ArgumentOutOfRangeException("Not real parameter"); }
            base.x = x;
            base.y = y;
            base.z = z;
        }

        public override float SurfaceArea()
        {
            return 2 * (x * y + x * z + z * y);
        }

        public override float Volume()
        {
            return x * y * z;
        }
    }

}