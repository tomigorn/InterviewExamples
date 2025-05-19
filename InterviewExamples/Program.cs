using InterviewExamples.Examples;
using System;

namespace InterviewExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an example to run:");
            Console.WriteLine("1 - Animal Factory");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AnimalFactoryExample.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
