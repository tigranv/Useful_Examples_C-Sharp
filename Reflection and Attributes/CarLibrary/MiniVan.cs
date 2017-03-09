using System;

namespace CarLibrary
{
    public class MiniVan : Car
    {
        public MiniVan()
        {

        }

        public MiniVan(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {

        }

        public override void Acceleration()
        {
            state = EngineState.EngineDead;
            Console.WriteLine("MINIVAN:  Crashed !!!!!!(It is MiniVan!)");
        }
    }
}
