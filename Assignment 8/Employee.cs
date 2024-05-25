using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

public class Employee : Person
{
    private static int count = 0;

    private int id;
    private double salary;
    private string designation;
    private DepartmentType dept;

    public int Id
    {
        get { return id; }
        private set { id = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public string Designation
    {
        get { return designation; }
        set { designation = value; }
    }

    public DepartmentType Dept
    {
        get { return dept; }
        set { dept = value; }
    }

    public Employee() : base()
    {
        id = ++count;
    }

    public Employee(string name, int age, double salary, string designation, DepartmentType dept) : base(name, age)
    {
        this.salary = salary;
        this.designation = designation;
        this.dept = dept;
        id = ++count;
    }

    public void Accept()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        Age = int.Parse(Console.ReadLine());

        Console.Write("Enter Salary: ");
        Salary = double.Parse(Console.ReadLine());

        Console.Write("Enter Designation: ");
        Designation = Console.ReadLine();

        Console.Write("Enter Department (0 for HR, 1 for IT, 2 for Finance): ");
        Dept = (DepartmentType)int.Parse(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Designation: {Designation}");
        Console.WriteLine($"Department: {Dept}");
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, Designation: {Designation}, Department: {Dept}";
    }
}

public enum DepartmentType
{
    HR,
    IT,
    Finance
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Employee emp = new Employee();
//        emp.Accept();
//        Console.WriteLine("\nEmployee Details:");
//        emp.Print();
//        Console.WriteLine("\nEmployee Details (String Format):");
//        Console.WriteLine(emp.ToString());
//    }
//}
