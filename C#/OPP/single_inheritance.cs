using System;

public class Employee
{
    public string Name;
    public int EmployeeID;
    
    public void DisplayInfo()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee ID: " + EmployeeID);
    }
}

public class Manager : Employee
{
    public string Department;
    
    public void DisplayManagerInfo()
    {
        Console.WriteLine("Department: " + Department);
    }
}
class Program
{
    static void Main()
    {
        Manager myManager = new Manager();
        myManager.Name = "Alice Johnson";
        myManager.EmployeeID = 12345;
        myManager.Department = "Human Resources";
       
        myManager.DisplayInfo();
        myManager.DisplayManagerInfo();
    }
}
