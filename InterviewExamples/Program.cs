﻿using InterviewExamples.Examples;
using System;

namespace InterviewExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an example to run:");
            Console.WriteLine("D - Digitec Example 1");
            Console.WriteLine("1 - Animal Factory");
            Console.WriteLine("2 - Try-Catch Exception Handling");
            Console.WriteLine("3 - Linq Null Exeption handling");
            Console.WriteLine("4 - Employee with inheritance, LINQ, and deferred execution");
            Console.WriteLine("5 - Events with Delegates and Mutable States and closures");
            Console.WriteLine("6 - Delegate Closure Trap");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "D":
                    ExerciseCustomDict.Run();
                    break;
                case "1":
                    AnimalFactoryExample.Run();
                    break;
                case "2":
                    TryCatchExceptionHandling.Run();
                    break;
                case "3":
                    LinqNullHandling.Run();
                    break;
                case "4":
                    Employee_Inheritance_Linq_DeferredExecution.Run();
                    break;
                case "5":
                    EventsDelegatesAndMutableStates.Run();
                    break;
                case "6":
                    DelegateClosureTrap.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
