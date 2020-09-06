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

            Employee sde1 = new Employee("Meetali", 4);
            Employee sde2 = new Employee("Pradeep", 3);
            Supervisor pm = new Supervisor("Pragati", 3);
            Supervisor spm = new Supervisor("Saroj", 4);

            pm.AddReportee(sde1);
            pm.AddReportee(sde2);

            spm.AddReportee(pm);


            //Actual operation 

            spm.ShowRating();
            Console.ReadLine();


        }
    }
}
