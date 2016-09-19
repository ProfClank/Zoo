using System;
using System.Collections.Generic;

namespace Zoo
{

    public class Lion : Animal
    {
        public int LoudnessOfRoar { get; set; }

        public Lion(string name, string size, string environment, int age, int loudnessOfRoar) 
            : base(name, size, environment, age)
        {
            LoudnessOfRoar = loudnessOfRoar;
        }

    }

    public class Animal
    {
        public Animal()
        {
        }

        public Animal(string name, string size, string environment, int age)
        {
            Name = name;
            Size = size;
            Environment = environment;
            Age = age;
        }

        public string Name { get; set; }
        public string Size { get; set; }
        public string Environment { get; set; }
        public int Age { get; set; }
    }



    public class AnimalList
    {
        //Created list of Animals
        public List<Animal> Animals = new List<Animal>
        {
            new Animal("Gorilla","Medium", "Forest", 10),
            new Animal() {Name="Giraffe", Size="Large", Environment="Savanna", Age=15 },
            new Animal() {Name="Shark", Size="Medium", Environment="Water", Age=5 },
            new Lion("Roary","Medium", "Savanna", 10, 100),
        };

        public void PrintAnimals()
        {
            foreach (Animal c in Animals)
            {

                if(c.GetType() == typeof(Lion))
                {
                    var loudnessOfRoar = ((Lion)c).LoudnessOfRoar;
                }

                string details2 = String.Format("Name: {0}, Age: {1}", c.Name, c.Age);
                string details = $"Name: {c.Name}, Size: {c.Size}";

               Console.WriteLine(details);
            }
        }
    }
}