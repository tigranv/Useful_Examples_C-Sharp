using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceleratorMagnets_InheritanceExample_
{
    public enum Material
    {
        Electromagnets,
        SCMagnets,
        Ferromagnets
    }

    public enum BendingRadius
    {
        weak,
        medium,
        hard
    }

    public enum FieldDirection
    {
        Left,
        Right
    }
}
