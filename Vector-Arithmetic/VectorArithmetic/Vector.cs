using System;
namespace VectorArithmetic
{
    public class Vector
    {
        Point end;

        public Vector(double endX, double endY)
        {
            end = new Point(endX, endY);
        }

        public Vector() : this(0, 0) { }

        public double length
        {
            get
            {
                return Math.Sqrt(Math.Pow(end.x, 2) + (Math.Pow(end.y, 2)));
            }
        }

        public static Vector operator *(Vector v, double k)
        {
            return new Vector(v.end.x * k, v.end.y * k);
        }

        public static Vector operator *(double k, Vector v)
        {
            return new Vector(v.end.x * k, v.end.y * k);
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.end.x * b.end.x + a.end.y * b.end.y;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.end.x + b.end.x, a.end.y + b.end.y);
        }

        public static Vector operator -(Vector a)
        {
            return new Vector(-a.end.x, -a.end.y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return a + (-b);
        }

        public void print()
        {
            Console.WriteLine("X: {0}, Y: {1}", end.x, end.y);
        }


    }
}
