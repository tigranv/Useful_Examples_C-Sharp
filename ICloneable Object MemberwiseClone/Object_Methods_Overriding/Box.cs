using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods_Overriding
{
    class Box
    {
        public Box(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        private double sideA;
        private double sideB;
        private double sideC;

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType())
            return false;

            Box inst = obj as Box;
            return  (inst.sideA == sideA) && (inst.sideB == sideB) && (inst.sideC == sideC);
        }

        public override string ToString()
        {
            return $"Box with sizes A = {sideA}, B = {sideB}, C = {sideC}"; ;
        }

        //public override int GetHashCode()
        //{
        //    return (int)sideA ^ (int)sideB ^ (int)sideC;
        //}

    }
}
