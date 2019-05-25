using System;
using System.Collections.Generic;

namespace TodoV1
{
    class CurrentList
    {
        public static void ShowList(List<ToDo> lst)
        {
            Console.Clear();
            Console.WriteLine("\nTo Do List:");
            foreach (var l in lst)
            {
                Console.WriteLine(l.Serial + ")" + " " + l.Name + " " + "(" + l.Status + ")");
            }
            ListOption.ShowOption();
        }

    }
}
