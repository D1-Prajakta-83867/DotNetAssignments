using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    internal class Date {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public static int CalculateAge(Date birthDate)
        {
            DateTime now = DateTime.Now;
            DateTime birthday = new DateTime(birthDate.year, birthDate.month, birthDate.day);
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;
            return age;
        }

        public void AcceptDate()
        {
            //Date();
            Console.WriteLine("Enter Day : ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month : ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());

        }
        public void PrintDate()
        {
            Console.WriteLine("Day : " + day);
            Console.WriteLine("Month : " + month);
            Console.WriteLine("Year : " + year);

        }

        public override string ToString()
        {
            return "\nDay : " + day + " Month : " + month + " Year : " + year + "\n";
        }

    }
    internal class Person {
        private string _name;
        private bool _gender;
        private Date birth;
        private string _address;

        public Person()
        { 
            birth = new Date();
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = new Date(1, 1, 2000);
           //this.birth=birth;
            this.address = address;
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }
        public Date Birth
        {
            get { return birth; }
            set { birth = value; }
        }
        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return Date.CalculateAge(birth); }
        }


        public void AcceptDetails()
        {
            
            Console.WriteLine("Enter Name : ");
            _name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Gender (true for male, false for female): ");
            _gender=Convert.ToBoolean(Console.ReadLine());

           birth.AcceptDate();

            Console.WriteLine("Enter Address : ");
            _address = Convert.ToString(Console.ReadLine());

        }
        public void PrintDetails()
        {
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Gender : " + (_gender?"Male":"Female"));
            birth.PrintDate();  
            Console.WriteLine("Address : " + _address);
            Console.WriteLine($"Age: {Age}");
        }

        public override string ToString()
        {
            return "\n Name : " + _name + " Gender : " + (_gender ? "Male" : "Female") + " Birthdate : " + birth.ToString() + " Address :" + _address + "  Age : " + Age + "\n";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.AcceptDetails();
            Console.WriteLine(p1);
            //p1.PrintDetails();
            Console.ReadLine();
        }
    }
}
