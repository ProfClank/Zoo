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
                "1) Look",
                "2) Build",
                "3) Animals"
            };

            userOptions.ForEach(Console.WriteLine);
        }
    }
}