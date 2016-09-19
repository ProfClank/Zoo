using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class userOptions
    {
        public static void userList()
        {
            List<string> userOptions = new List<string>
            {
                "Look",
                "Build",
                "Add Animal"
            };

            userOptions.ForEach(Console.WriteLine);
        }
    }
}
