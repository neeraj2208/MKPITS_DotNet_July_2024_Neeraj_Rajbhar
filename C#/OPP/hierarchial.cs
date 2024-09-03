using System;

public class Employee
{
    public string Name;
    public int EmployeeID

    public void DisplayInfo()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee ID: " + EmployeeID);
    }
}

public class Manager : Employee
{
    public string Department;

    public Manager(string name, int employeeID, string department)
    {
        Name = name;
        EmployeeID = employeeID;
        Department = department;
    }

    public void DisplayManagerInfo()
    {
        Console.WriteLine("Department: " + Department);
    }
}

public class Developer : Employee
{
    public string ProgrammingLanguage;

    public Developer(string name, int employeeID, string programmingLanguage)
    {
        Name = name;
        EmployeeID = employeeID;
        ProgrammingLanguage = programmingLanguage;
    }

    public void DisplayDeveloperInfo()
    {
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager("Alice Johnson", 101, "Human Resources");
        Developer developer = new Developer("Bob Smith", 102, "C#");

        manager.DisplayInfo();
        manager.DisplayManagerInfo();
        developer.DisplayInfo();
        developer.DisplayDeveloperInfo();
    }
}
