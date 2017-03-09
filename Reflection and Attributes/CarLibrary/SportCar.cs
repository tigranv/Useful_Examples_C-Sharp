using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class SportCar : Car
    {
        public SportCar()
        {

        }

        public SportCar(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {

        }

        public override void Acceleration()
        {
            Console.WriteLine("SPORTCAR:  Strong Acceleration !");
        }

        // To show that Reflection can reach also nested internal clases
        internal class SecretCar : Car
        {
            public override void Acceleration()
            {
                throw new NotImplementedException();
            }
        }
    }
}
