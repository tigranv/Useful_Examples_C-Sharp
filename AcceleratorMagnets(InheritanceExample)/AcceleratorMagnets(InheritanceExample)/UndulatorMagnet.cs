using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceleratorMagnets_InheritanceExample_
{
    public class UndulatorMagnet : Magnet
    {
        // Constructor with default period number and period length;
        public UndulatorMagnet(float B, Material material, int GLenght) : base(B, material, GLenght)
        {
        }

        // Constructor with full optionality
        public UndulatorMagnet(float B, Material material, int GLenght, int y, int n) : base(B, material, GLenght)
        {
            Periodlenght = y;
            NumberOfPeriods = n;
        }

        private int Periodlenght = 10;
        private int NumberOfPeriods = 10;

        public void PlotTrajectory()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("The trajectory is  ");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("   *");
            Console.WriteLine("  *");
            Console.WriteLine("   *");
            Console.WriteLine("    *");
            Console.WriteLine("     *"); 
            Console.WriteLine("       *");
            Console.WriteLine("      *");
            Console.WriteLine("     *");
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("   *");
            Console.WriteLine("  *");
            Console.WriteLine("   *");
            Console.WriteLine("    *");
            Console.WriteLine("     *");
            Console.WriteLine("       *");
            Console.WriteLine("      *");
            Console.WriteLine("     *");

        }


    }
    }
