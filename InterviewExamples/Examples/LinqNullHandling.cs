using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewExamples.Examples
{
    internal class LinqNullHandling
    {
        public static void Run()
        {

            var users = new List<User?>
            {
                new User { Name = "Alice", Age = 30 },
                null,
                new User { Name = "Bob", Age = 17 },
                new User { Name = "Charlie", Age = 25 },
                null
            };

            var adultNames = users
                .Where(u => u != null && u.Age >= 18)
                .Select(u => u.Name)
                .OrderBy(name => name)
                .ToList();

            foreach (var name in adultNames)
            {
                Console.WriteLine(name);
            }
        }
    }
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
