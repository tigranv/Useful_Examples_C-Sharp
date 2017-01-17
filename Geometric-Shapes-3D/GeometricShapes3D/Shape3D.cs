namespace GeometricShapes3D
{
    public abstract class Shape3D
    {
        protected float x;
        protected float y;
        protected float z;

        public abstract float SurfaceArea();
        public abstract float Volume();
    }
}
