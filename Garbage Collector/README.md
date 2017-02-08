# Working with Garbage Collector <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 

The .NET Framework's garbage collector manages the allocation and release of memory for your application. Each time you create a new object, the common language runtime allocates memory for the object from the managed heap. As long as address space is available in the managed heap, the runtime continues to allocate space for new objects. However, memory is not infinite. Eventually the garbage collector must perform a collection in order to free some memory. The garbage collector's optimizing engine determines the best time to perform a collection, based upon the allocations being made. When the garbage collector performs a collection, it checks for objects in the managed heap that are no longer being used by the application and performs the necessary operations to reclaim their memory.

In the common language runtime (CLR), the garbage collector serves as an automatic memory manager. It provides the following benefits:

* Enables you to develop your application without having to free memory.

* Allocates objects on the managed heap efficiently.

* Reclaims objects that are no longer being used, clears their memory, and keeps the memory available for future allocations. Managed objects automatically get clean content to start with, so their constructors do not have to initialize every data field.

* Provides memory safety by making sure that an object cannot use the content of another object.


> **GC Generations** is a demonstration of Object Resurrection using GC.ReRegisterForFinalize

```c#
    class Program
    {
        static void Main()
        {
            Thread.Sleep(4000);
            // Method GetTotalMemory() heap memory in bytes
            // if true - run GC, if false without running
            Console.WriteLine("memory in heap {0}", GC.GetTotalMemory(false));

            // get max number of generations in system
            Console.WriteLine("heap have {0} generation\n", (GC.MaxGeneration + 1));

            // creating new object in heap.
            Car car = new Car("RENAULT", 120);

            Console.WriteLine(car.ToString());

            // GetGeneration() gives the generation where our object
            Console.WriteLine("\nObject car in {0} generation\n", GC.GetGeneration(car));

            Console.WriteLine("Size of memeory in heap {0}", GC.GetTotalMemory(false));

            // Array of objects for testing
            object[] array = new object[10000000];

            ShowGCStat();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new object();
            }

            Console.WriteLine("size of heap {0}", GC.GetTotalMemory(false));
            array = null;

            Console.WriteLine("\nstart  GC ");

            ShowGCStat();
            var start = DateTime.Now;
            // Collect - check generation .            
            GC.Collect();

            // Метод WaitForPendingFinalizers() - stops thread, while finilaser will work
            // calls after  GC.Collect().
            GC.WaitForPendingFinalizers();

            Console.WriteLine("GC worked                  " + (DateTime.Now - start).TotalMilliseconds + "\n");

            Console.WriteLine("size of memeory {0}", GC.GetTotalMemory(false));

            Console.WriteLine("\nObject car in {0} generation.\n", GC.GetGeneration(car));

            // Метод CollectionCount() - how much checked this object

            ShowGCStat();

            
            Console.ReadKey();
        }

        private static void ShowGCStat()
        {
            Console.WriteLine("\ngeneration 0 checked {0} times", GC.CollectionCount(0));
            Console.WriteLine("generation 0 checked {0} times", GC.CollectionCount(1));
            Console.WriteLine("generation 0 checked {0} times", GC.CollectionCount(2));
        }
    }
```

> **The output is**

> Memory in heap - 158756

>Heap have 3 generation

>RENAULT with speed120 km/h

>Object car in 0 generation

>Size of memeory in heap 158756

>generation 0 checked 0 times

>generation 0 checked 0 times

>generation 0 checked 0 times

>Size of memeory in heap 160095232

>start  GC

>generation 0 checked 26 times

>generation 0 checked 19 times

>generation 0 checked 4 times

>GC worked                  83.2352

>size of memeory 97444

>Object car in 2 generation.


>generation 0 checked 27 times

>generation 0 checked 20 times

>generation 0 checked 5 times
>---------------------------------------------------------------------------------





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
