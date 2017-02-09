using System.Threading;

namespace ShallowAndDeepCloneOfHouse
{
    public class House 
    {
        public Street street { get; set; }
        public string City { get; set; }

        public House(Street street, string City)
        {
            Thread.Sleep(1000); // to see that memberwiseClone is not calling constructor
            this.street = street;
            this.City = City;
        }
     
        // Shallow cloning using MemberwiseClone
        public object CloneWithMemberwise()
        {
            return MemberwiseClone() as House;
        }

        // Shallow cloning using Constructor
        public object CloneWithConstructor()
        {
            return new House(this.street, this.City);
        }

        public object DeepClone()
        {
            return new House(this.street.Clone() as Street, this.City);
            // // or in case if class Street dont have clone
            //House other = (House)this.MemberwiseClone();
            //other.street = new Street(street.Name);
            //other.City = String.Copy(City);
            //return other;
        }
    }
}
