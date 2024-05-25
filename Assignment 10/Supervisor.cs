public class Supervisor : Employee
{
    private int subordinates;

    public int Subordinates
    {
        get { return subordinates; }
        set { subordinates = value; }
    }

    public Supervisor() : base()
    {
        Designation = "Supervisor";
    }

    public Supervisor(string name, int age, double salary, DepartmentType dept, int subordinates) : base(name, age, salary, "Supervisor", dept)
    {
        Subordinates = subordinates;
    }

    public new void Accept()
    {
        base.Accept();

        Console.Write("Enter number of subordinates: ");
        Subordinates = int.Parse(Console.ReadLine());
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Subordinates: {Subordinates}");
    }

    public override string ToString()
    {
        return base.ToString() + $", Subordinates: {Subordinates}";
    }
}

