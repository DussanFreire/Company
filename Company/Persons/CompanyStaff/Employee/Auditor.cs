using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Auditor : Employee
    {
        public Auditor()
        {
            Position = "Auditor";
            Salary = 3000;
        }
        
        public override void ReceiveSalary()
        {
            Console.WriteLine($"{Name} recived the auditor salary ({Salary}$)");
        }

        public override void PresentYourSelf()
        {
            Console.WriteLine($"Hello my name is {Name} and I'm the {Position}, my job is to control sales");
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("******EMPLOYEE********");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine("**********************");
        }

        public override void Work()
        {
            Console.WriteLine("I'm doing my work");
        }
    }
}
