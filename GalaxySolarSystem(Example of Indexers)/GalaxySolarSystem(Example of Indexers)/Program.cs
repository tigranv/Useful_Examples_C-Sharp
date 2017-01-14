using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySolarSystem_Example_of_Indexers_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's create new solar system
            // Select the galaxy, sun, and the number of planets(1-10)
            NewGalaxy Galaxy1 = new NewGalaxy(Galaxy.Andromeda, Sun.Sirius, 4);

            // Choose your planets names (indexer by number of planets)
            Galaxy1[0] = (Planets)1;
            Galaxy1[1] = (Planets)12;
            Galaxy1[2] = Planets.Venus;
            Galaxy1[3] = Planets.Aquarii;

            // Choose directions of your planets ( indexer by names of planets )
            Galaxy1[Planets.Venus] = 0;
            Galaxy1[Planets.Aquarii] = 1;
            Galaxy1[Planets.Jupiter] = 2;
            Galaxy1[Planets.Proxima] = 3;

            // Information about Your New Solar System
            Galaxy1.GetInfo();

            // planets names
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Your planets are");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < Galaxy1.Numberofplanets; i++)
            {
                Console.WriteLine(Galaxy1[i]);
            }

            // planets directions
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Direction of your planets is");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("<<<<-{0}->>>>", Galaxy1.sun);
            for (int i = 0; i < Galaxy1.Numberofplanets; i++)
            {
                for (int j = 0; j < Galaxy1.Numberofplanets; j++)
                {
                    if(Galaxy1[Galaxy1[j]]==i)
                    {
                        Console.ForegroundColor = (ConsoleColor)i+1;
                        Console.Write("------>{0}", Galaxy1[j]);
                        break;
                    }
                }           
            }

            Console.ReadKey();
        }
    }
}
