using System;
using System.Collections.Generic;

namespace TodoV1
{
    class ListOption
    {
        public static void ShowOption()
        {
            List<string> option = new List<string>
            {
                "a)Mark To Do as Done (Press 4)",
                "b)Return to Menu (Press 5)"
            };

            Console.WriteLine("\nOptions:");

            foreach (var l in option)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\nEnter a number:");
        }

    }
}
