using CompositePattern.Composite;
using CompositePattern.Leaf;
using System;

namespace CompositePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            //Form objects

            Employee lakshman = new Employee("Lakshman", 4);
            Employee ram = new Employee("Ram", 3);
            Supervisor vibhisan = new Supervisor("Vibhisan", 3);
            Supervisor ravan = new Supervisor("Ravan", 4);

            vibhisan.AddReportee(lakshman);
            vibhisan.AddReportee(ram);
            ravan.AddReportee(vibhisan);


            //Actual operation 

            vibhisan.ShowRating();
            Console.ReadLine();


        }
    }
}
