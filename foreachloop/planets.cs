using System;

namespace foreachloop
{

    class planet
    {
        protected int scaleFactor = 30;
        public string Name { get; set; }
        public int DistanceFromSun {get;set;}
        public planet(string name)
        {
            Name = name;
        }

        public planet(string name, int distance)
        {
            Name = name;
            DistanceFromSun = distance;
        }

        public override string ToString()
        {
            return $"{Name} is {DistanceFromSun} millions of km from sun";
        }
        public void Print(planet prevoiusPlanet)
        {
            int d = prevoiusPlanet != null ? (DistanceFromSun - prevoiusPlanet.DistanceFromSun) / scaleFactor : 0;
            for(int i = 0; i < d; i++)
            {
                 Console.Write(" ");           
            }
            Console.Write(Name);
        }
    }
}