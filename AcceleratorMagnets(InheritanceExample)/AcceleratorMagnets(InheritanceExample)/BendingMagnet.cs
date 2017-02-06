using System;

namespace AcceleratorMagnets_InheritanceExample_
{
    public class BendingMagnet : Magnet
    {
        // Constructor with default bending radius and Field direction
        public BendingMagnet(float B, Material material, int GLenght) : base(B, material, GLenght)
        {
            
        }

        // Constructor with full optionality
        public BendingMagnet(float B, Material material, int GLenght, BendingRadius beta, FieldDirection fd) : base(B, material, GLenght)
        {
            this.beta = beta;
            this.fd = fd;
        }

        private BendingRadius beta = BendingRadius.medium;
        private FieldDirection fd = FieldDirection.Left;

        // Method for geting trajectory 
        public override void PlotTrajectory()
        {
            switch (beta)
                {
                    case BendingRadius.weak:
                        if (fd == FieldDirection.Left) Console.WriteLine("Trajectory function of bending with WEAK field and Left direction");
                        else Console.WriteLine("Trajectory function of bending with WEAK field and Right direction");                
                        break;

                    case BendingRadius.medium:
                    if (fd == FieldDirection.Left) Console.WriteLine("Trajectory function of bending with MEDIUM field and Left direction");
                    else Console.WriteLine("Trajectory function of bending with MEDIUM field and Right direction");
                    break;

                    case BendingRadius.hard:
                    if (fd == FieldDirection.Left) Console.WriteLine("Trajectory of bending with HARD field and Left direction");
                    else Console.WriteLine("Trajectory function of bending with HARD field and Right direction");
                    break;

                    default:
                        break;
                }
            Console.WriteLine(new string('*', 70));
        }      
    }
}
