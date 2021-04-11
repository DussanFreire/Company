using System;

namespace Company
{
    public interface ICompanyStaff : IPerson, IBaseEmployee
    {
        public void DisplayInformation();
    }
}