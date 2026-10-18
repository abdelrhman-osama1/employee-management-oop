using System.Security.Cryptography.X509Certificates;

class Employee
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee("Ahmed", 8000));
        employees.Add(new Employee("Abdo", 45000));
        employees.Add(new Manager("Ali", 20000, 2000));
        for (int i = 0; i < employees.Count; i++)
        {
            employees[i].Work();
        }
    }
    public string? Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string EmployeeName, decimal EmployeeSalary)
    {
        Name = EmployeeName;
        Salary = EmployeeSalary;
    }
    public virtual void Work()
    {
        Console.WriteLine($"Employee: {Name} salary is : {Salary}");
    }
}

class Manager : Employee
{
    public decimal Bonus { get; set; }

    public Manager(string EmployeeName, decimal EmployeeSalary, decimal bonus) : base(EmployeeName, EmployeeSalary)
    {
        Bonus = bonus;
    }

    public override void Work()
    {
        Console.WriteLine($"Employee: {Name} Salary is : {Salary} Bonus From Manager:{Bonus}");
    }
}