using System;

struct Student
{
    private string name;
    private bool gender;
    private int age;
    private int std;
    private char div;
    private double marks;



    // Default constructor (automatically provided for structs)
    // Parameterized constructor
    public Student(string name, bool gender, int age, int std, char div, double marks)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.std = std;
        this.div = div;
        this.marks = marks;
    }

    // Get and Set methods
    public string GetName() => name;
    public void SetName(string name) => this.name = name;

    public bool GetGender() => gender;
    public void SetGender(bool gender) => this.gender = gender;

    public int GetAge() => age;
    public void SetAge(int age) => this.age = age;

    public int GetStd() => std;
    public void SetStd(int std) => this.std = std;

    public char GetDiv() => div;
    public void SetDiv(char div) => this.div = div;

    public double GetMarks() => marks;
    public void SetMarks(double marks) => this.marks = marks;

    // Method to accept data from console
    public void AcceptDetails()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();

        Console.Write("Enter gender (true for male, false for female): ");
        gender = bool.Parse(Console.ReadLine());

        Console.Write("Enter age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Enter standard: ");
        std = int.Parse(Console.ReadLine());

        Console.Write("Enter division: ");
        div = char.Parse(Console.ReadLine());

        Console.Write("Enter marks: ");
        marks = double.Parse(Console.ReadLine());
    }

    // Method to print data to console
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Gender: {(gender ? "Male" : "Female")}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Standard: {std}");
        Console.WriteLine($"Division: {div}");
        Console.WriteLine($"Marks: {marks}");
    }
}

//#region
//class Student
//{
//    static void Main(string[] args)
//    {
//        Student student = new Student();
//        student.AcceptDetails();
//        Console.WriteLine("\nStudent Details:");
//        student.PrintDetails();
//        Console.ReadLine(); 
//    }
//}
//#endregion
