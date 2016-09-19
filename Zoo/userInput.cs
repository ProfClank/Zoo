using System;

namespace Zoo
{
    class UserInput
    {
        public static void Input()
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    new AnimalList().PrintAnimals();

                    break;

                case "2":
                    Console.ReadKey();

                    break;

                default:
                    Console.WriteLine("Not Recognised");
                    break;
            }
        }
    }
}