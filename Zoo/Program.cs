using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome_Message.Welcome();
            userOptions.userList();
            User_Input.userInput();
            Console.Read();
        }
    }
}
