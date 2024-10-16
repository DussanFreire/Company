# Company Polymorphism Example in C#

This project demonstrates the concept of **polymorphism** in C# using a company structure, where various roles (CEO, Auditor, Department Director, etc.) are represented as classes inheriting from a common base and implementing shared interfaces.

## Project Overview

The project includes:

- **Interfaces**: `IBaseEmployee`, `IClient`, `ICompanyStaff`, and `IPerson`.
- **Base Classes**: `Employee`, `Manager`, and `Client`.
- **Derived Classes**: `CEO`, `Auditor`, `DepartmentDirector`.
- **Company Class**: Manages the company’s staff and clients, allowing for operations like adding new members and displaying their information.

### Key Concepts Demonstrated
1. **Polymorphism**: Classes like `CEO`, `Auditor`, and `DepartmentDirector` inherit from `Manager` or `Employee` and implement abstract methods in their own way.
2. **Interfaces**: Interfaces such as `IClient`, `ICompanyStaff`, and `IBaseEmployee` enforce a contract for shared methods and properties across different classes.
3. **Abstraction**: Abstract classes such as `Employee` and `Manager` provide a base for common behaviors while requiring derived classes to provide specific implementations.
4. **Encapsulation**: Class properties like `Position`, `Salary`, and `Department` are encapsulated with getters and setters, ensuring controlled access.

## Classes and Interfaces

### Interfaces
- **`IPerson`**: A base interface for all people-related entities.
- **`IClient`**: Extends `IPerson` and includes client-specific properties like `Email` and `TelephoneNumber`.
- **`IBaseEmployee`**: Provides the basic structure for employee roles, including properties like `Position` and `Salary`, and a method `ReceiveSalary()`.
- **`ICompanyStaff`**: Combines `IPerson` and `IBaseEmployee`, and adds the `DisplayInformation()` method for staff members.

### Abstract Classes
- **`Employee`**: An abstract class defining common properties for all employees, such as `Id`, `Name`, `Position`, `Salary`, and methods like `ReceiveSalary()`, `Work()`, and `DisplayInformation()`.
- **`Manager`**: An abstract class inheriting from `Employee` and adding manager-specific methods like `ControlTheProcess()`.

### Concrete Classes
- **`Client`**: Implements `IClient`, representing a company's client.
- **`Auditor`**: Extends `Employee` to represent a specific type of employee responsible for auditing.
- **`CEO`**: Inherits from `Manager`, representing the highest role in the company.
- **`DepartmentDirector`**: Inherits from `Manager` and represents a director responsible for a department in the company.

## Example Usage

### Creating a Company and Adding Staff

```csharp
using Company;

Company company = new Company();

// Creating staff
CEO ceo = new CEO { Id = 1, Name = "John Doe", Gender = "Male" };
Auditor auditor = new Auditor { Id = 2, Name = "Jane Smith", Gender = "Female" };
DepartmentDirector director = new DepartmentDirector { Id = 3, Name = "Alex Brown", Gender = "Non-binary" };

// Adding staff to the company
company.AddNewMemberToTheStaff(ceo);
company.AddNewMemberToTheStaff(auditor);
company.AddNewMemberToTheStaff(director);

// Displaying staff information
company.DisplayCompanyStafInformation();
```

### Sample Output

``` bash
*************************COMPANY STAFF*********************
*****MANAGER********
Position: CEO
Name: John Doe
Salary: 8000
********************
******EMPLOYEE********
Name: Jane Smith
Salary: 3000
Position: Auditor
**********************
*****MANAGER********
Position: Departament Director
Name: Alex Brown
Salary: 5000
Departament: Financial
********************
***********************************************************
```

### How to Run

1.	Clone this repository to your local machine.
2.	Open the solution in Visual Studio or your preferred C# development environment.
3.	Run the project to see the polymorphism in action.

### Features

* Staff Management: Easily add and manage different types of employees and clients.
* Flexible Hierarchy: Use polymorphism to extend the company structure and create new roles as needed.
* Console Output: Display information about staff members dynamically through the DisplayCompanyStafInformation() method.
