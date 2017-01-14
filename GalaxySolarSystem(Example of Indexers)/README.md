# Working with Interfacies 

```c#
// Let's create new solar system
// Select the galaxy, sun, and the number of planets(1-10)
NewGalaxy Galaxy1 = new NewGalaxy(Galaxy.Andromeda, Sun.Sirius, 4);

// Choose your planets names (indexer by number of planets)
Galaxy1[0] = (Planets)1;
Galaxy1[1] = (Planets)12;
Galaxy1[2] = Planets.Venus;
Galaxy1[3] = Planets.Aquarii;

// Choose directions of your planets ( indexer by names of planets )
Galaxy1[Planets.Venus] = 0;
Galaxy1[Planets.Aquarii] = 1;
Galaxy1[Planets.Jupiter] = 2;
Galaxy1[Planets.Proxima] = 3;
```

The output is the full information about your Solar system

![Output] (https://cloud.githubusercontent.com/assets/24522089/21958406/df04d260-dac6-11e6-9773-189126c50797.PNG)
