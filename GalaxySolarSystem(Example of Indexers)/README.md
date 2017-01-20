# Working with Indexers  <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

Let's create new solar system using class **NewGalaxy**                 
Select the galaxy, sun(from Galaxy and Sun enumerations) and the number of planets.

```c#
NewGalaxy Galaxy1 = new NewGalaxy(Galaxy.Andromeda, Sun.Sirius, 4);
```

Choose your planets names using **indexer by planet numbers** and select planets from Planets enumeration
```c#
Galaxy1[0] = (Planets)1;
Galaxy1[1] = (Planets)12;
Galaxy1[2] = Planets.Venus;
Galaxy1[3] = Planets.Aquarii;
```

Choose positions for your planets using **indexer by planets names**
```c#
Galaxy1[Planets.Venus] = 0;
Galaxy1[Planets.Aquarii] = 1;
Galaxy1[Planets.Jupiter] = 2;
Galaxy1[Planets.Proxima] = 3;
```
Use methhod **GetInfo** for base information about your galaxy and sun.             
Getting information about positions of planets organised as follows(**indexer by numbers used in indexer by names**)
```C#
for (int i = 0; i < Galaxy1.Numberofplanets; i++)
            {
                for (int j = 0; j < Galaxy1.Numberofplanets; j++)
                {
                    if(Galaxy1[Galaxy1[j]]==i)
                    {
                        Console.ForegroundColor = (ConsoleColor)i+1;
                        Console.Write("------>{0}", Galaxy1[j]);
                        break;
                    }
                }           
            }
```
###The output is the full information about your Solar system
![Output] (https://cloud.githubusercontent.com/assets/24522089/21958406/df04d260-dac6-11e6-9773-189126c50797.PNG)

###Here are the codes of indexers
```C#
// Indexer by planets numbers for names
        public Planets this[int index]
        {
            get
            {
                if (index >= 0 && index < numberofplanets)
                    return planets[index];
                else throw new ArgumentOutOfRangeException();
            }
            set
            {

                if (index >= 0 && index < numberofplanets)
                    planets[index] = (Planets)value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        // Indexer by planets names, for position
        public int this[Planets index]
        {
            get
            {
                for (int i = 0; i < planets.Length; i++)
                    if (planets[i] == index) return position[i];
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                int indicate = 0;
                for (int i = 0; i < planets.Length; i++)
                    if (planets[i] == index) { position[i] = value; indicate++; }
                if(indicate == 0) throw new ArgumentOutOfRangeException();
            }
        }
```

> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
