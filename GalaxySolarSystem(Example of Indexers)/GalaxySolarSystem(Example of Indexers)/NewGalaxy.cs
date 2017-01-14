using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySolarSystem_Example_of_Indexers_
{
    class NewGalaxy
    {
        public NewGalaxy(Galaxy galaxy, Sun sun, int numberofplanets)
        {
            this.galaxy = galaxy;
            this.sun = sun;
            Numberofplanets = numberofplanets;
            planets = new Planets[numberofplanets];
        }

        private static int numberofplanets;
        private Galaxy galaxy;
        private Sun sun;  
        private Planets[] planets;

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
         
        public Planets this[int index]
        {
            get    
            {     
                if (index >= 0 && index < numberofplanets)
                    return planets[index];
                else  throw new ArgumentOutOfRangeException(); 
            }
            set   
            {

                if (index >= 0 && index < numberofplanets)
                planets[index] = (Planets)value;
                else throw new ArgumentOutOfRangeException();
            }
        }
    }
}
