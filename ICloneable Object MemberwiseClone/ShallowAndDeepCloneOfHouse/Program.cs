using System;
using System.Diagnostics;

namespace ShallowAndDeepCloneOfHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            House Hause1 = new House(new Street("Kievyan"), "Yerevan");

            Console.WriteLine("--> MemberwiseClone() method does not using constructor <--");
            //Cloning with constructor
            timer.Start();
            House Clone1 = Hause1.CloneWithConstructor() as House;
            timer.Stop();
            Console.WriteLine($"Cloning With Constructor- \t  {timer.ElapsedTicks} ticks");

            timer.Reset();

            //Cloning with memberwizeClone
            timer.Start();
            House Clone2 = Hause1.CloneWithMemberwise() as House;
            timer.Stop();
            Console.WriteLine($"Cloning With MemberwiseClone- \t  {timer.ElapsedTicks} ticks");
            Console.WriteLine();


            // example of shallow cloning
            Console.WriteLine("-----> Example of Shallow Cloning <------");
            Console.WriteLine($"Original \n Street is --> {Hause1.street.Name} \n City is --> {Hause1.City}");
            Console.WriteLine();

            House Clone = Hause1.CloneWithMemberwise() as House;
            // changing parameters of original
            Hause1.City = "Geneva";
            Hause1.street.Name = "Rive";

            //  shallow copy 
            Console.WriteLine($"Original after changing\n Street is --> {Hause1.street.Name} \n City is --> {Hause1.City}");
            Console.WriteLine();
            Console.WriteLine($"Clone \n Street is --> {Clone.street.Name} \n City is --> {Clone.City}");
            Console.WriteLine(new string('-', 30));

            // Deep cloning
            // setting original properties
            Hause1.City = "Yerevan";
            Hause1.street.Name = "Kievyan";
            Console.WriteLine("-----> Example of deep Cloning <------");
            Console.WriteLine($"Original \n Street is --> {Hause1.street.Name} \n City is --> {Hause1.City}");
            Console.WriteLine();

            House DeepClone = Hause1.DeepClone() as House;
            // changing parameters of original
            Hause1.City = "Geneva";
            Hause1.street.Name = "Rive";

            Console.WriteLine($"Original after changing\n Street is --> {Hause1.street.Name} \n City is --> {Hause1.City}");
            Console.WriteLine();
            Console.WriteLine($"Clone \n Street is --> {DeepClone.street.Name} \n City is --> {DeepClone.City}");




            // Cloning with Deepcloning
            Console.ReadKey();
        }
    }
}
