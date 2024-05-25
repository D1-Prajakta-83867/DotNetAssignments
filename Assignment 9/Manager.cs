using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Manager : Employee
{
    private double bonus;

    public double Bonus
    {
        get { return bonus; }
        set { bonus = value; }
    }

    public Manager() : base()
    {
        Designation = "Manager";
    }

    public Manager(string name, int age, double salary, DepartmentType dept, double bonus) : base(name, age, salary, "Manager", dept)
    {
        Bonus = bonus;
    }

    public new void Accept()
    {
        base.Accept();

        Console.Write("Enter Bonus: ");
        Bonus = double.Parse(Console.ReadLine());
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Bonus: {Bonus}");
    }

    public override string ToString()
    {
        return base.ToString() + $", Bonus: {Bonus}";
    }
}

