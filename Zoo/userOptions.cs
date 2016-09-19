using System;
using System.Collections.Generic;

namespace Zoo
{
    class UserOptions
    {
        public static void userList()
        {
            List<string> userOptions = new List<string>
            {
                "1) Animals",
                "2) Exit"
            };
            
            userOptions.ForEach(Console.WriteLine);
        }
    }
}