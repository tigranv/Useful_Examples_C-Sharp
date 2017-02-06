namespace GeometricShapes3D
{
    public abstract class Shape3D: IMovable
    {
        public Shape3D(Point3D p)
        {
            Location = p;
        }

        protected Point3D Location { get; set; }
        public abstract float ShapeVolume { get; }
        public abstract float SurfaceArea { get; }

        public void MoveToPoint(Point3D m)
        {
            Location = m;
        }

    public void MoveTo(float x1, float y1, float z1)
        {
            Location = new Point3D(x1, y1, z1);
        }

        public void MoveBy(float dx, float dy, float dz)
        {
            Location = new Point3D(Location.X +dx, Location.Y + dy, Location.Z + dz);
        }
    }
}
