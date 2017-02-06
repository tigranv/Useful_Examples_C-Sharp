using System;

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
        private int NumberOfPeriods = 80;

        public override void PlotTrajectory()
        {           
            Console.WriteLine("Trajectory function of undulator with period length of {0}, and period numbers {1}", Periodlenght, NumberOfPeriods);
            Console.WriteLine(new string('*', 70));
        }
    }


    }
    
