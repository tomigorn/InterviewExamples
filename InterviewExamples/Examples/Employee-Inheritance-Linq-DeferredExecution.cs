using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewExamples.Examples
{
    internal class Employee_Inheritance_Linq_DeferredExecution
    {
        public static void Run()
        {

            var people = new List<Person>
        {
            new Employee("Alice", 30, "HR"),
            new Manager("Bob", 45, "Engineering"),
            new Employee("Charlie", 25, "Engineering"),
            new Manager("Dana", 38, "HR")
        };

            var engineeringTeam = people
                .OfType<Employee>()
                .Where(p => p.Department == "Engineering" && !(p is Manager))
                .ToList();

            foreach (var person in people.OfType<Manager>())
            {
                person.Team.AddRange(engineeringTeam);
            }

            var roles = people
                .Where(p => p.Age > 28)
                .OrderBy(p => p.Name)
                .Select(p => new
                {
                    p.Name,
                    Role = p.GetRole()
                });

            foreach (var entry in roles)
            {
                Console.WriteLine($"{entry.Name}: {entry.Role}");
            }
        }
    }


    public abstract class Person
    {
        public string Name { get; }
        public int Age { get; }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string GetRole();
    }

    public class Employee : Person
    {
        public string Department { get; }

        public Employee(string name, int age, string dept)
            : base(name, age)
        {
            Department = dept;
        }

        public override string GetRole() => $"Employee in {Department}";
    }

    public class Manager : Employee
    {
        public List<Employee> Team { get; }

        public Manager(string name, int age, string dept)
            : base(name, age, dept)
        {
            Team = new List<Employee>();
        }

        public override string GetRole() => $"Manager of {Team.Count} in {Department}";
    }
}
