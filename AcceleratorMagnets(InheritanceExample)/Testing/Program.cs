using System;
using AcceleratorMagnets_InheritanceExample_;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {

            //// compile time Polimorphism
            //BendingMagnet Bending = new BendingMagnet(1, Material.SCMagnets, 10, BendingRadius.weak, FieldDirection.Left);
            //UndulatorMagnet Undulator = new UndulatorMagnet(1, Material.Ferromagnets, 15);

            //// get information about magnets
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("------------- Bending Magnet --------------");
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Bending.GetInformation();
            //Bending.PlotTrajectory();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("------------- Undulator Magnet --------------");
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Undulator.GetInformation();
            //Undulator.PlotTrajectory();
            //Console.ReadKey();


            // run time polimorphism
            Magnet UserMagnet = null;
            Console.WriteLine("Enter the magnet that You Need");
            string magnetName = Console.ReadLine();
            // Lets suppose that user can add other options too,(to note write more code)

            switch (magnetName)
            {
                case "bending":
                    UserMagnet = new BendingMagnet(1, Material.SCMagnets, 10, BendingRadius.weak, FieldDirection.Left);
                    break;

                case "undulator":
                    UserMagnet = new UndulatorMagnet(1, Material.Ferromagnets, 15);
                    break;

                default:
                    {
                        Console.WriteLine("Error: Wrong magnet name");
                        break;
                    }
            }

            if(UserMagnet != null)
            {
                UserMagnet.PlotTrajectory();
                UserMagnet.GetInformation();
            }


            Console.ReadKey();
        }
    }
}
