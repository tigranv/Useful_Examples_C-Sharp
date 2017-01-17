namespace VectorArithmetic
{
    public class Vector
    {
        public Point A { get; set; }
        public Point B { get; set; }

        public Vector(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }

        public static Vector operator +(Vector V1, Vector V2)
        {
            return new Vector(new Point(1,2), new Point(1, 2));
        }

        public static Vector operator -(Vector V1, Vector V2)
        {
            return new Vector(new Point(1, 2), new Point(1, 2));
        }

        public static Vector operator *(Vector V1, Vector V2)
        {
            return new Vector(new Point(1, 2), new Point(1, 2));
        }

    }
}
