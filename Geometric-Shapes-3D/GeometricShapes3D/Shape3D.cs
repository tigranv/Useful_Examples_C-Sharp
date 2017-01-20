namespace GeometricShapes3D
{
    public abstract class Shape3D
    {
        public Shape3D(Point3D p)
        {
            this.Location = p;
        }

        protected Point3D Location { get; set; }
        public abstract float ShapeVolume { get; }
        public abstract float SurfaceArea { get; }
    }
}
