
using System;

namespace GeometricShapes3D
{
    public class Parallelepiped : Shape3D 
    {
        public Parallelepiped(Point3D location, float a, float b, float c, float angle) : base(location)
        {
            A = a;
            B = b;
            C = c;
            smallAngle = AngleInPi(angle);
        }


        //Lengths of  sides
        protected float A;
        protected float B;
        protected float C;

        //small  angle 
        protected float smallAngle;


        // overriding methods for area and volume
        public override float SurfaceArea
        {
            get
            {
                return 2 * (A * C + A * B + B * C * (float)Math.Sin(smallAngle));
            }
        }

        public override float ShapeVolume
        {
            get
            {
                return A * B * C * (float)Math.Sin(smallAngle);
            }
        }

        
        // Method for correct angle
        private float AngleInPi(float angle)
        {
            float finalAngle;
            if (angle >= 0)
            {
                finalAngle = angle % (float)(Math.PI * 2);

                if (finalAngle > (float)Math.PI)
                    return -(float)(Math.PI * 2) - finalAngle;
                else
                    return finalAngle;
            }
            else
            {
                finalAngle = angle % (float)(Math.PI * 2);

                if (finalAngle < -(float)Math.PI)
                    return (float)(Math.PI * 2) - (-finalAngle);
                else
                    return finalAngle;
            }
        }

        
    }

}