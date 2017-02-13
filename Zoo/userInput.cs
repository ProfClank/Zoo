using System;

namespace Zoo
{
    class UserInput
    {
        public static void Input()
        {
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new AnimalList().PrintAnimals();
            } else if (choice == "2")
            {
                Console.ReadKey();
            } else
            {
                Console.WriteLine("Not Recognised");
                UserOptions.userList();
            }

            //switch (choice)
            //{
            //    case "1":

            //        new AnimalList().PrintAnimals();

            //        break;

            //    case "2":
            //        Console.ReadKey();

            //        break;

            //    default:
            //        Console.WriteLine("Not Recognised");
            //        Input();
            //        break;
            //}
        }
    }
}