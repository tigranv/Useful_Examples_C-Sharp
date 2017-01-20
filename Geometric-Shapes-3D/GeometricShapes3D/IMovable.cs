using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes3D
{
    public interface IMovable
    {
        //void MoveBy(float dx, float dy, float dz);
        void MoveTo(float x, float y, float z);
        void MoveToPoint(Point3D p);
    }
}
