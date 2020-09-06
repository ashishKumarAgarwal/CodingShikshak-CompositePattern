using CompositePattern.Component;
using System;

namespace CompositePattern.Leaf
{
    internal class Employee : IEmployee
    {
        private string Name { get; }
        private int Rating { get; }

        public Employee(string name, int rating)
        {
            Name = name;
            Rating = rating;
        }

        public void ShowRating()
        {
            Console.WriteLine($"Rating of {Name} : {Rating}");
        }
    }
}