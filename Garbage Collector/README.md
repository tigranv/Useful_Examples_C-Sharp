# Working with Garbage Collector <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 

> **Nine Lives of a Cat** is a demonstration of Object Resurrection using GC.ReRegisterForFinalize

```c#
    class Cat
    {
        ~Cat()
        {
            Program.counter++;
            if (Program.counter < 10) Console.WriteLine($"Killing cat!!!");
            Program.Instance = this;

            if (Program.counter < 9)
            {
                Console.WriteLine($"Myauuu , it was my {Program.counter} live");
                GC.ReRegisterForFinalize(this);
            }

            if (Program.counter == 9)
            {
                Console.WriteLine($"MyauuuVaaaaax it was my {Program.counter} live, You Killed Me Completely ");
                GC.ReRegisterForFinalize(this);
            }

        }
    }
    class Program
    {
        public static Cat Instance { get; set; }
        public static int counter = 0;

        static void Main(string[] args)
        {
            // new Cat
            Instance = new Cat();

            Instance = null; // Killing cut 1 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 2 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 3 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 4 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 5 time
            GC.Collect();

            Instance = null; // Killing cut 6 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 7 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 8 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 9 time
            GC.Collect();
            Console.ReadKey();

            Instance = null; // Killing cut 1st time
            GC.Collect();
            Console.ReadKey();

            Console.ReadKey();
        }
    }
```

> Projects written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
