using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Company
    {
        private List<ICompanyStaff> staff;
        private List<IClient> clients;
        public Company()
        {
            staff = new List<ICompanyStaff>();
            clients = new List<IClient>();
        }
        
        public void AddNewMemberToTheStaff(ICompanyStaff newMember)
        {
            staff.Add(newMember);
        }

        public void AddNewClient(IClient newClient)
        {
            clients.Add(newClient);
        }
        public void DisplayCompanyStafInformation() {
            
            Console.WriteLine("*************************COMPANY STAFF*********************");
            foreach (ICompanyStaff member in staff) {
                member.DisplayInformation();
            } 
            Console.WriteLine("***********************************************************");
        }
    }
}
