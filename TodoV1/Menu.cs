using System;
using System.Collections.Generic;

namespace TodoV1
{
    class Menu
    {
        public static void ShowMenu()
        {
            Console.Clear();
            List<string> menu = new List<string>
            {
                "a)List todo (Press 1)",
                "b)Create todo (Press 2)",
                "c)Exit (Press 3)"
            };


            Console.WriteLine("Main menu\n");
            foreach (var l in menu)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\nEnter a number:");
        }
    }
}
