using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewExamples.Examples
{
    internal class AnimalFactoryExample
    {
        public static void Run() //in a standalone app this would be static void Main(string[] args)
        {
            var factory = new AnimalFactory();

            var a1 = factory.GetAnimal("cat");
            Console.WriteLine(a1.Speak());

            var a2 = factory.GetAnimal("dog");
            Console.WriteLine(a2.Speak());

            var a3 = factory.GetAnimal("bird");
            Console.WriteLine(a3.Speak());
        }
    }

    public interface IAnimal
    {
        string Speak();
    }

    public class Cat : IAnimal
    {
        public string Speak() => "Meow";
    }

    public class Dog : IAnimal
    {
        public string Speak() => "Woof";
    }

    public class AnimalFactory
    {
        private readonly Dictionary<string, Func<IAnimal>> _creators = new()
    {
        { "cat", () => new Cat() },
        { "dog", () => new Dog() }
    };

        public IAnimal GetAnimal(string type)
        {
            if (_creators.TryGetValue(type, out var creator))
            {
                return creator();
            }

            return new UnknownAnimal(type);
        }
    }

    public class UnknownAnimal : IAnimal
    {
        private readonly string _type;

        public UnknownAnimal(string type)
        {
            _type = type;
        }

        public string Speak() => $"Unknown animal: {_type}";
    }
}
