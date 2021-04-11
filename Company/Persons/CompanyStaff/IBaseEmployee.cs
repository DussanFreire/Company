using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public interface IBaseEmployee
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public void ReceiveSalary();
    }
}
