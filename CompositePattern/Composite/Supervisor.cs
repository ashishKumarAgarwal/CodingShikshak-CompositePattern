using CompositePattern.Component;
using System;
using System.Collections.Generic;

namespace CompositePattern.Composite
{
    internal class Supervisor : IEmployee
    {
        private string Name { get; }
        private int Rating { get; }

        private readonly List<IEmployee> _reportees = new List<IEmployee>();

        public Supervisor(string name, int rating)
        {
            Name = name;
            Rating = rating;
        }

        public void ShowRating()
        {
            Console.WriteLine($"Rating of {Name} : {Rating}\n");
            Console.WriteLine($"-----Rating of {Name}'s Reportees ------- \n");
            _reportees.ForEach(rep => rep.ShowRating());

        }
        public void AddReportee(IEmployee employee)
        {
            _reportees.Add(employee);
        }
    }
}