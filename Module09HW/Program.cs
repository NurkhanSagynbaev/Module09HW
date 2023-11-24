using System;

class Employee
{
    protected string name;
    protected int age;
    protected double salary;

    public Employee(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
    }

    public virtual double CalculateAnnualSalary()
    {
        return salary * 12;
    }
}

class Manager : Employee
{
    private double bonus;

    public Manager(string name, int age, double salary, double bonus)
        : base(name, age, salary)
    {
        this.bonus = bonus;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Bonus: {bonus}");
    }

    public override double CalculateAnnualSalary()
    {
        return base.CalculateAnnualSalary() + bonus;
    }
}

class Developer : Employee
{
    private int linesOfCodePerDay;

    public Developer(string name, int age, double salary, int linesOfCodePerDay)
        : base(name, age, salary)
    {
        this.linesOfCodePerDay = linesOfCodePerDay;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Lines of Code per Day: {linesOfCodePerDay}");
    }

    public override double CalculateAnnualSalary()
    {
        // Дополнительная оплата за количество строк кода (просто для примера)
        double additionalPay = linesOfCodePerDay * 0.1;
        return base.CalculateAnnualSalary() + additionalPay;
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager("John Manager", 35, 60000, 5000);
        Developer developer = new Developer("Alice Developer", 28, 70000, 1000);

        Console.WriteLine("Manager's Info:");
        manager.GetInfo();
        Console.WriteLine($"Annual Salary: {manager.CalculateAnnualSalary()}\n");

        Console.WriteLine("Developer's Info:");
        developer.GetInfo();
        Console.WriteLine($"Annual Salary: {developer.CalculateAnnualSalary()}");
    }
}
