using System;

    class Employee
    {
        public string Name;
        public string LastName;
        public static string StartDate;
        public Position JobTitle;


        public Employee(string name, string lastname, string StartDate, Position jobtitle)
        {
            this.Name = name;
            this.LastName = lastname;
            Employee.StartDate = StartDate;
            this.JobTitle = jobtitle;

        }
        public static double DiscoverGrade(string StartDate)
        {
            double dateValueForGrade = (DateTime.Now - DateTime.Parse(StartDate)).TotalDays;
            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
            return 1.1;
            else if (dateValueForGrade >= 3650)
            return 1.25;
            else
            return 1.5;
        }
    }
    class ШефКухар : Position
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (100000 + 3 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.22;
        }
    }
    class Кухар : Position
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (10000 + 1 * bonus) * grade;
        }

        public override void ApplyTax()
        {
            tax = salary * 0.22;
        }
    }
    class СуШеф : Position
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (50000 + 3 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.22;
        }
    }
    abstract class Position
    {
        public double salary;
        public double tax;

        public abstract void ApplyBonus(double bonus, double grade);
        public abstract void ApplyTax();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Position JobTitle = new Кухар();
            Employee emp = new Employee("Віталій", "Миколенко", "7.06.2021", JobTitle);
            double grade = Employee.DiscoverGrade("7.06.2021 ");
            Console.WriteLine("Персональні дані працівника: " + "\r\n" + "Ім'я: " + emp.Name + "\r\n" + "Прізвище: " + emp.LastName + "\r\n" + "Посада: " + emp.JobTitle);
            JobTitle.ApplyBonus(25000, grade);
            JobTitle.ApplyTax();
            Console.WriteLine("Зарплата: " + emp.JobTitle.salary + "\r\n" + "Налог: " + emp.JobTitle.tax);
            Console.ReadKey();
        }
    }