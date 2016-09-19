using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class animalList
    {
        public class Animal
        {
            public string Name { get; set; }
            public string Size { get; set; }
            public string Environment { get; set; }
            public int Age { get; set; }
        }

        //Created list of Animals
        static List<Animal> animals = new List<Animal>
        {
            new Animal {Name="Gorilla", Size="Medium", Environment="Forest", Age=10 },
            new Animal {Name="Giraffe", Size="Large", Environment="Savanna", Age=15 },
            new Animal {Name="Shark", Size="Medium", Environment="Water", Age=5 }
            animals.ForEach(Print);
        };
    }
}