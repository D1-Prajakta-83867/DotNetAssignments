
class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();
        manager.Accept();
        Console.WriteLine("\nManager Details:");
        manager.Print();
        Console.WriteLine("--------------------------------------------------------");

       Console.WriteLine("\nManager Details (String Format):");
        Console.WriteLine(manager.ToString());
        Console.WriteLine("---------------------------------------------------------");

        Console.ReadLine();
    }
}