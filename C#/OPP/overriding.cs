using System;

public class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee class .");
    }
}
public class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager class.");
    }
}
public class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Developer class.");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee();
        employee.Work();

        Employee manager = new Manager();
        manager.Work();

        Employee developer = new Developer();
        developer.Work();  

        Employee emp1 = new Manager();
        Employee emp2 = new Developer();

        emp1.Work();  
        emp2.Work();  
    }
}
