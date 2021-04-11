using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {

            // Company *****************************
            Company company = new Company();


            // CLient *****************************
            Console.WriteLine("**************************************");
            IClient sergio = new Client();
            sergio.Name = "Sergio";
            sergio.TelephonNumber = 77777777;
            sergio.Email = "sergio_the_boss@hotmail.com";
            sergio.PresentYourSelf();


            IPerson roxana = new Client();
            roxana.Name = "Roxana";
            roxana.Gender = "Female";



            // Employees *****************************
            Console.WriteLine("**************************************");

            ICompanyStaff juan = new Auditor();
            juan.Name = "Juan";
            juan.Gender = "Male";
            juan.PresentYourSelf();
            juan.ReceiveSalary();

            Employee alex= new Auditor();
            alex.Name = "Alex";
            alex.Gender = "Male";
            alex.PresentYourSelf();
            alex.Work();

            Auditor sandra = new Auditor();
            sandra.Name = "Sandra";
            sandra.Gender = "Female";
            sandra.PresentYourSelf();

             
            // Managers *****************************
            Console.WriteLine("**************************************");

            CEO pedro = new CEO();
            pedro.Name = "Pedro";
            pedro.Gender = "Male";
            pedro.YellAtSomeone();

            DepartmentDirector maria = new DepartmentDirector();
            maria.Name = "Maria";
            maria.Gender = "Female";
            maria.CongratulateSomeone();

            ICompanyStaff camila = new DepartmentDirector();
            camila.Name = "Camila";
            camila.Gender = "Female";
            camila.PresentYourSelf();

            Console.WriteLine();
            Console.WriteLine();


            // Add staff to the company *****************************
            company.AddNewMemberToTheStaff(juan);
            company.AddNewMemberToTheStaff(alex);
            company.AddNewMemberToTheStaff(sandra);
            company.AddNewMemberToTheStaff(pedro);
            company.AddNewMemberToTheStaff(maria);
            company.AddNewMemberToTheStaff(camila);
            company.DisplayCompanyStafInformation();


            // Add clients to the company *****************************
            company.AddNewClient(sergio);
            company.AddNewClient(roxana as IClient);
        }
    }
}
