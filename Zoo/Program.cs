using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage.Welcome();
            UserOptions.userList();
            UserInput.Input();
            Console.Read();
        }
    }
}