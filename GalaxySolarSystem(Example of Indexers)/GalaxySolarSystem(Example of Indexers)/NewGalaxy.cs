using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySolarSystem_Example_of_Indexers_
{
    class NewGalaxy
    {
        // User constructor
        public NewGalaxy(Galaxy galaxy, Sun sun, int numberofplanets)
        {
            this.galaxy = galaxy;
            this.sun = sun;
            Numberofplanets = numberofplanets;
            planets = new Planets[numberofplanets];
            direction = new int[numberofplanets];
        }

        // fields
        private static int numberofplanets;
        private Galaxy galaxy;
        public Sun sun;  
        private Planets[] planets;
        private int[] direction;

        // Indexer for planet namies
        public Planets this[int index]
        {
            get
            {
                if (index >= 0 && index < numberofplanets)
                    return planets[index];
                else throw new ArgumentOutOfRangeException();
            }
            set
            {

                if (index >= 0 && index < numberofplanets)
                    planets[index] = (Planets)value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        // Indexer for planet directions
        public int this[Planets index]
        {
            get
            {
                for (int i = 0; i < planets.Length; i++)
                    if (planets[i] == index) return direction[i];
                    return -1;
            }
            set
            {
                for (int i = 0; i < planets.Length; i++)
                    if (planets[i] == index) direction[i] = value;
                    else throw new ArgumentOutOfRangeException();
            }
        }

        // setter getter for number of planets
        public int Numberofplanets
        {
            get
            {
                return numberofplanets;
            }
            set
            {
               if(value > 0 && value < 11 ) numberofplanets = value;
               else  throw new ArgumentOutOfRangeException(); 
            }
        }

        // information about solar system
        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Galaxy Info");
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (galaxy)
            {
                case Galaxy.Andromeda:
                    Console.WriteLine("Designation:  M31 or NGC 224\nType:  Spiral\nDiameter:  220,000 ly\nDistance:  2.54 Mly\nNumber of Stars:  1 trillion");
                    break;
                case Galaxy.MilkyWay:
                    Console.WriteLine("Number of Stars:  100 - 400 billion\nType:  Barred Spiral\nDiameter:  100,000 - 180,000 ly\nAge:  13.6 Billion years");
                    break;
                default:
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Sun Info");
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (sun)
            {
                case Sun.SolarSystem:
                    Console.WriteLine("Age:   4.568 billion years\nLocation:   Local Interstellar Cloud, Local Bubble,Orion–Cygnus Arm, {0}\nSystem mass: 1.0014 Solar masses", galaxy);
                    break;
                case Sun.AlphaCentauri:
                    Console.WriteLine("Age:   4.568 billion years\nLocation:   Local Interstellar Cloud, Local Bubble,Orion–Cygnus Arm, {0}\nSystem mass: 1.0014 Solar masses", galaxy);
                    break;
                case Sun.Luhman:
                    Console.WriteLine("Age:   4.568 billion years\nLocation:   Local Interstellar Cloud, Local Bubble,Orion–Cygnus Arm, {0}\nSystem mass: 1.0014 Solar masses", galaxy);
                    break;
                case Sun.Sirius:
                    Console.WriteLine("Age:   4.568 billion years\nLocation:   Local Interstellar Cloud, Local Bubble,Orion–Cygnus Arm, {0}\nSystem mass: 1.0014 Solar masses", galaxy);
                    break;
                default:
                    break;
            }
        }
    }
}
