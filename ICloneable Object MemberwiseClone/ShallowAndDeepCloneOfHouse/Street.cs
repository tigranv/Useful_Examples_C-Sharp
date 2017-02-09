using System;

namespace ShallowAndDeepCloneOfHouse
{
    public class Street :ICloneable
    {
        public string Name { get; set; }

        public Street(string name)
        {
            Name = name;
        }

        // implimenting IClonable interface
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
