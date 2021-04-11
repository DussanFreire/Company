﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    abstract class Employee : ICompanyStaff
    {
        // Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set ; }
        // Methods
        public abstract void ReceiveSalary();
        public abstract void PresentYourSelf();
        public abstract void Work();
        public abstract void DisplayInformation();
    }
}
