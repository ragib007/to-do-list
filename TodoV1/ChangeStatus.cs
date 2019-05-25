using System;
using System.Collections.Generic;

namespace TodoV1
{
    class ChangeStatus
    {
        public static List<ToDo> MarkDone(List<ToDo> lst)
        {
            Console.WriteLine("\nEnter Serial of To Do:");
            int num = Convert.ToInt32(Console.ReadLine());
            lst[num - 1].Status = ToDo.StatusType.Done;
            Console.Clear();
            Console.WriteLine("To Do (" + num + ") Marked as Done\n");
            Console.WriteLine("Press Any Key to Go to List");
            Console.ReadKey();
            CurrentList.ShowList(lst);
            return lst;
        }
    }
}
