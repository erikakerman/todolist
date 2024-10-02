using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>();

        while (true)
        {
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();

            Console.Write("Enter due date (yyyy-MM-dd): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            tasks.Add(new Task(title, dueDate));

            Console.Write("Add another task? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
                break;
        }

        Console.WriteLine("\nYour tasks:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}