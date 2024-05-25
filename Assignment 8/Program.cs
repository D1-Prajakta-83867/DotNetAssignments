using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.Accept();
                Console.WriteLine("\nEmployee Details:");
                emp.Print();
                Console.WriteLine("\nEmployee Details (String Format):");
                Console.WriteLine(emp.ToString());
            Console.ReadLine();
            }
        

    }
}
