# Working with Interfacies 

Let's create new solar system using class **NewGalaxy**
Select the galaxy, sun(from Galaxy and Sun enumerations) and the number of planets.

```c#
NewGalaxy Galaxy1 = new NewGalaxy(Galaxy.Andromeda, Sun.Sirius, 4);
```

// Choose your planets names using **indexer by planet numbers** and select planets from Planets enumeration
```c#
Galaxy1[0] = (Planets)1;
Galaxy1[1] = (Planets)12;
Galaxy1[2] = Planets.Venus;
Galaxy1[3] = Planets.Aquarii;
```

// Choose positions for your planets using **indexer by planets names**
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
The output is the full information about your Solar system

![Output] (https://cloud.githubusercontent.com/assets/24522089/21958406/df04d260-dac6-11e6-9773-189126c50797.PNG)

###Here are the codes of indexers


