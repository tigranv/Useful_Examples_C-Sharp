using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxySolarSystem_Example_of_Indexers_
{
    class Galaxy
    {
        private static int numberofplanets;
        private string[] planets = new string[numberofplanets];

        public int Numberofplanets
        {
            set
            {
               if(value > 0 && value < 15 ) numberofplanets = value;
               else { throw new ArgumentOutOfRangeException(); }
            }
        }
         
        public string this[int index]
        {
            get    
            {
                return planets[index];
            }
            set   
            {
                planets[index] = value;
            }
        }
    }
}
