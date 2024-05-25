class Program
{
    static void Main(string[] args)
    {
        WageEmp wageEmp = new WageEmp();
        wageEmp.Accept();
        Console.WriteLine("_______________________________________________");
        Console.WriteLine("\nWage Employee Details:");
        wageEmp.Print();
        Console.WriteLine("___________________________________________________________________________________________________");

        Console.WriteLine("\nWage Employee Details (String Format):");
        Console.WriteLine(wageEmp.ToString());
        Console.WriteLine("___________________________________________________________________________________________________");

        Console.ReadLine();
    }
}