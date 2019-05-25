using System;
using System.Collections.Generic;

namespace TodoV1
{
    class NewTodo
    {
        public static List<ToDo> CreateTodo(List<ToDo> lst)
        {
            Console.Clear();
            Console.WriteLine("\nEnter Name of New To Do:");
            int Len = lst.Count;
            var newObj = new ToDo
            {
                Serial = Len + 1,
                Name = Console.ReadLine(),
                Status = ToDo.StatusType.Open
            };
            lst.Add(newObj);
            Console.WriteLine("\nNew To Do Created");
            Console.WriteLine("\nPress 5 to Return to Menu");
            return lst;
        }
    }
}
