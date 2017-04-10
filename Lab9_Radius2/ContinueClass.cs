using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Radius2
{
    class ContinueClass
    {
        public static bool Continue()
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            string input = Console.ReadLine().ToLower();

            bool run = true;

            if (input == "n" || input == "no")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input == "y" || input == "yes")
            {
                run = true;
            }
            else
            {
                run = Continue();
            }
            return run;
        }
    }
}
