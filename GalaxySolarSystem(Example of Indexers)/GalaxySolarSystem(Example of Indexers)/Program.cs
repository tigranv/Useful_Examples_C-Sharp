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
            NewGalaxy Galaxy1 = new NewGalaxy(Galaxy.Andromeda, Sun.AlphaCentauri, 7);
            //Galaxy1[0] = (Planets)1;
            //Galaxy1[1] = (Planets)12;
            //Galaxy1[2] = (Planets)9;
            //Galaxy1[3] = (Planets)4;
            //Galaxy1[4] = Planets.Venus;
            //Galaxy1[5] = Planets.Pluto;
            //Galaxy1[6] = Planets.Aquarii;

            //for (int i = 0; i <= Galaxy1.Numberofplanets; i++)
            //{
            //    Console.WriteLine(Galaxy1[i]);
            //}

            Galaxy1[1] = Planets.Aquarii;
            Console.WriteLine(Galaxy1[1]);

            Console.ReadKey();
        }
    }
}
