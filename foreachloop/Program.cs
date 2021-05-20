using System;
using System.Collections.Generic;

namespace foreachloop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<planet> planets = new List<planet>();
            planets.Add(new planet("Mercury", 57));
            planets.Add(new planet("Venus", 108));
            planets.Add(new planet("Earth", 149));
            planets.Add(new planet("Mars", 228));
            planets.Add(new planet("Jupiter", 780));
            planets.Add(new planet("Saturn", 1437));
            planets.Add(new planet("Uranus", 2871));
            planets.Add(new planet("Neptune", 4530));
            planets.Add(new planet("Pluto", 5900));

            foreach(planet p in planets)
            {
                Console.WriteLine(p);
            } 

            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].Name == "Pluto")
                    planets.RemoveAt(i);
            } 

            planet innerPlanet = null;
            foreach(planet p in planets)
            {
               p.Print(innerPlanet);
               innerPlanet = p;
            }              
        }
    }
}
