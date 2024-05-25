using System;
class Program
{
    static void Main(string[] args)
    {
        Supervisor supervisor = new Supervisor();
        supervisor.Accept();
        Console.WriteLine("____________________________________________________");

        Console.WriteLine("\nSupervisor Details:");
        supervisor.Print();
        
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("\nSupervisor Details (String Format):");
        Console.WriteLine(supervisor.ToString());
        Console.WriteLine("________________________________________________________");

        Console.ReadLine();
    }
}