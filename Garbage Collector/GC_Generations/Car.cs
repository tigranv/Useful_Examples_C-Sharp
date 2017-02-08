using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Generations
{
    public class Car
    {
        private int speed;
        private string name;

        public Car()
        {
        }

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public override string ToString()
        {
            return string.Format("{0} with speed{1} km/h", name, speed);
        }
    }
}
