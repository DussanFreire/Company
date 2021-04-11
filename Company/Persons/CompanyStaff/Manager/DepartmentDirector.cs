using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class DepartmentDirector : Manager
    {
        public string  Departament { get; set; }
        public DepartmentDirector()
        {
            Position = "Departament Director";
            Salary = 5000;
            Departament = "Financial";
        }
        public void CongratulateSomeone()
        {
            Console.WriteLine("Nice Job!");
        }
        
        public override void ReceiveSalary()
        {
            Console.WriteLine($"{Name}, take your salary ({Salary} $), you are a great {Position}!");
        }
        public override void PresentYourSelf()
        {
            Console.WriteLine($"Hello my name is {Name} and I'm the {Position}, my job is to make this departament more productive");
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("*****MANAGER********");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Departament: {Departament}");
            Console.WriteLine("********************");
        }

        public override void ControlTheProcess()
        {
            Console.WriteLine($"The dapartament work it's ok");
        }
    }
}
