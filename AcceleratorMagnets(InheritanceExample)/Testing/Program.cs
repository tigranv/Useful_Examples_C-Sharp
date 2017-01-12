using System;
using AcceleratorMagnets_InheritanceExample_;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating 2 magnets
            BendingMagnet Bending = new BendingMagnet(1, Material.SCMagnets, 10, BendingRadius.weak, FieldDirection.Left);
            UndulatorMagnet Undulator = new UndulatorMagnet(1, Material.Ferromagnets, 15);
            // get information about magnets
            Bending.GetInformation();
            Bending.PlotTrajectory();
            Undulator.GetInformation();
            Undulator.PlotTrajectory();
            Console.ReadKey();
        }
    }
}
