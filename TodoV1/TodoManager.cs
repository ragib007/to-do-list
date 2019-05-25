using System;
using System.Collections.Generic;



namespace TodoV1
{
    class TodoManager
    {
        static void Main(string[] args)
        {

            List<ToDo> Lst = new List<ToDo>();

            Lst = CsvManager.ReadCsv(@"D:\C#\ToDoList\prac\InitRef\InitRef\Todo.csv");
            Menu.ShowMenu();

            while (true)
            {

                var index = Console.ReadLine();

                if (index == "1")
                {
                    CurrentList.ShowList(Lst);
                }

                if (index == "2")
                {
                    Lst = NewTodo.CreateTodo(Lst);
                }

                if (index == "3")
                    break;

                if (index == "4")
                {
                    Lst = ChangeStatus.MarkDone(Lst);
                }

                if (index == "5")
                {
                    Menu.ShowMenu();
                }

            }

            CsvManager.WriteCsv(@"D:\C#\ToDoList\prac\InitRef\InitRef\Todo.csv", Lst);
        }

    }

}
