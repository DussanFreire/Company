using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class CEO : Manager
    {
        // Constructor
        public CEO()
        {
            Position = "CEO";
            Salary = 8000;
        }
        // Methods
        public void YellAtSomeone()
        {
            Console.WriteLine("I'm the CEO, you will do whatever I want!");
        }

      
        public override void ReceiveSalary()
        {
            Console.WriteLine($"{Name}, {Position} of the enterprise, received {Salary} $");
        }

        public override void PresentYourSelf()
        {
            Console.WriteLine($"Hello my name is {Name} and I'm the one who makes the decisions here because I'm the CEO!");
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("*****MANAGER********");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine("********************");

        }

        public override void ControlTheProcess()
        {
            Console.WriteLine($"Everything in the company it's ok");
        }
    }
}
