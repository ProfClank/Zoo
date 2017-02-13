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

    public class Mammal : Animal
    {
        public bool Monkey { get; set; }

        public Mammal(string name, string size, string environment, int age, bool monkey)
            : base(name, size, environment, age)
        {
            Monkey = monkey;
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
            new Animal("Giraffe", "Large", "Savanna", 15),
            new Animal("Shark", "Medium", "Water", 5),
            new Lion("Lion","Medium", "Savanna", 10, 100),
            new Mammal("Baboon", "Medium", "Forest", 3, true)
        };

        public void PrintAnimals()
        {
            foreach (Animal c in Animals)
            {

                if(c.GetType() == typeof(Lion))
                {
                    var loudnessOfRoar = ((Lion)c).LoudnessOfRoar;
                }

                string details = $"Name: {c.Name}, Size: {c.Size}, Environemnt: {c.Environment}, Age: {c.Age}";

                Console.WriteLine(details);
            }

            {
                UserOptions.userList();
                UserInput.Input();
            }
        }
    }
}