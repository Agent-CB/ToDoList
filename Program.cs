// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List program!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add to the list.");
                Console.WriteLine("Enter 2 to remove from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the program.");

                option = Console.ReadLine()?.Trim().ToLower();

                if (option == "1")
                {
                    Console.WriteLine("Enter the task you would like to add:");
                    string task = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(task))
                    {
                        taskList.Add(task.Trim());
                        Console.WriteLine("Task added to the list.");
                    }
                    else
                    {
                        Console.WriteLine("No task entered.");
                    }
                }
                else if (option == "2")
                {
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine("The task list is empty.");
                        continue;
                    }

                    Console.WriteLine("Current tasks:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i} : {taskList[i]}");
                    }

                    Console.WriteLine("Enter the number of the task you would like to remove:");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int taskNumber) && taskNumber >= 0 && taskNumber < taskList.Count)
                    {
                        taskList.RemoveAt(taskNumber);
                        Console.WriteLine("Task removed.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("Your current task list:");
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine("(empty)");
                    }
                    else
                    {
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"{i} : {taskList[i]}");
                        }
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }

            Console.WriteLine("Thank you for using the program.");
        }
    }
}