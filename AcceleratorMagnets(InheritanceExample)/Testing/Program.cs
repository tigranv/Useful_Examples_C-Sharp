using System;
using AcceleratorMagnets_InheritanceExample_;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            BendingMagnet Bending = new BendingMagnet(1, Material.SCMagnets, 10, BendingRadius.weak, FieldDirection.Left);
            UndulatorMagnet Undulator = new UndulatorMagnet(1, Material.SCMagnets, 10);
            Bending.GetInformation();
            Bending.PlotTrajectory();
            Undulator.GetInformation();
            Undulator.PlotTrajectory();
            Console.ReadKey();
        }
    }
}
