using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Attilaaaaaaaaaaaaaaaaaaa", Age = 28 };
            Person person1 = new Person() { Name = "András", Age = 101 };
            Person person2 = new Person() { Name = "Elemér", Age = 28 };

            Console.WriteLine($"Is Person valid: {person.Validate()}");
            //Console.WriteLine($"Is Person valid: {validator.Validate(person1)}");
            //Console.WriteLine($"Is Person valid: {validator.Validate(person2)}");
        }
    }
}
