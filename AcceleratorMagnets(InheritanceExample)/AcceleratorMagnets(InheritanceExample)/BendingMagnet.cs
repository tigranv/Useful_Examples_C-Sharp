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
        public void PlotTrajectory()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("The trajectory is  ");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;

            switch (beta)
                {
                    case BendingRadius.weak:
                        if (fd == FieldDirection.Left)
                        {
                            Console.WriteLine("* * * * * * * * * * ");
                            Console.WriteLine("                      *");
                            Console.WriteLine("                           *");
                            Console.WriteLine("                                *");
                            Console.WriteLine("                                     *");
                        }
                        else
                        {
                            Console.WriteLine("                                     *");
                            Console.WriteLine("                                *");
                            Console.WriteLine("                           *");
                            Console.WriteLine("                      *");
                            Console.WriteLine("* * * * * * * * * * ");
                        }                
                        break;
                    case BendingRadius.medium:
                        if (fd == FieldDirection.Left)
                        {
                            Console.WriteLine("* * * * * * * * * * ");
                            Console.WriteLine("                    *");
                            Console.WriteLine("                      *");
                            Console.WriteLine("                        *");
                            Console.WriteLine("                          *");
                            Console.WriteLine("                            *");
                        }
                        else
                        {
                            Console.WriteLine("                            *");
                            Console.WriteLine("                          *");
                            Console.WriteLine("                        *");
                            Console.WriteLine("                      *");
                            Console.WriteLine("                    *");
                            Console.WriteLine("* * * * * * * * * * ");                     
                        }
                        
                        break;
                    case BendingRadius.hard:
                        if (fd == FieldDirection.Left)
                        {
                            Console.WriteLine("* * * * * * * * * * ");
                            Console.WriteLine("                   *");
                            Console.WriteLine("                    *");
                            Console.WriteLine("                     *");
                            Console.WriteLine("                      *");
                            Console.WriteLine("                       *");
                            Console.WriteLine("                        *");
                        }
                        else
                        {
                            Console.WriteLine("                        *");
                            Console.WriteLine("                       *");
                            Console.WriteLine("                      *");
                            Console.WriteLine("                     *");
                            Console.WriteLine("                    *");
                            Console.WriteLine("                   *");
                            Console.WriteLine("* * * * * * * * * * ");              
                        }            
                        break;
                    default:
                        break;
                }     
            }

        
    }
}
