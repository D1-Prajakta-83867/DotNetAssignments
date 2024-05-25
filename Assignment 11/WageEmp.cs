public class WageEmp : Employee
{
    private int hours;
    private int rate;

    public int Hours
    {
        get { return hours; }
        set { hours = value; }
    }

    public int Rate
    {
        get { return rate; }
        set { rate = value; }
    }

    public WageEmp() : base()
    {
        Designation = "Wage";
    }

    public WageEmp(string name, int age, double salary, DepartmentType dept, int hours, int rate) : base(name, age, salary, "Wage", dept)
    {
        Hours = hours;
        Rate = rate;
    }

    public new void Accept()
    {
        base.Accept();

        Console.Write("Enter Hours: ");
        Hours = int.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        Rate = int.Parse(Console.ReadLine());
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Hours: {Hours}");
        Console.WriteLine($"Rate: {Rate}");
    }

    public override string ToString()
    {
        return base.ToString() + $", Hours: {Hours}, Rate: {Rate}";
    }
}