using System;

class Date
{
    private int day;
    private int month;
    private int year;

    // Default constructor
    public Date()
    {
        day = 1;
        month = 1;
        year = 2000;
    }

    // Parameterized constructor
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    // Properties
    public int Day
    {
        get { return day; }
        set { day = value; }
    }

    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Method to accept data from console
    public void AcceptDate()
    {
        Console.Write("Enter day: ");
        day = int.Parse(Console.ReadLine());

        Console.Write("Enter month: ");
        month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        year = int.Parse(Console.ReadLine());
    }



    public void PrintDate()
    {
        Console.WriteLine($"Date: {day}/{month}/{year}");
    }

    // check validity of date
    public bool IsValid()
    {
        return day >= 1 && day <= 31 && month >= 1 && month <= 12 && year > 0;
    }

    // return data of object in string format
    public override string ToString()
    {
        return $"{day}/{month}/{year}";
    }

    //  calculate difference between two dates in years
    public static int DifferenceInYears(Date date1, Date date2)
    {
        int yearsDiff = date2.year - date1.year;

        if (date2.month < date1.month || (date2.month == date1.month && date2.day < date1.day))
            yearsDiff--;

        return yearsDiff;
    }

    // Overloading "-" operator
    public static int operator -(Date date1, Date date2)
    {
        return DifferenceInYears(date1, date2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Date date1 = new Date(1, 1, 2000);
        Date date2 = new Date();

        Console.WriteLine("Enter date 2:");
        date2.AcceptDate();

        date1.PrintDate();
        date2.PrintDate();

        Console.WriteLine($"Difference in years: {Date.DifferenceInYears(date1, date2)}");
        Console.WriteLine($"Difference in years (using operator): {date1 - date2}");
        Console.ReadLine();
    }
}
