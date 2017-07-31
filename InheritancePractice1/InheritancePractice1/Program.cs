using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice1
{
    public class Employee
    {
        // Base Class
        public string FirstName;
        public string LastName;
        public int EmployeeId;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine($"My first name is {FirstName} and my last name is {LastName}");

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.FullTimeId = 1001;
            ft.FirstName = "Mary";
            ft.LastName = "Mithchel";
            ft.PrintFullName();

            Console.WriteLine("");

            PartTimeEmployee pt = new PartTimeEmployee();
            pt.PartTimeID = 3005;
            pt.FirstName = "Peter";
            pt.LastName = "Parker";
            pt.PrintFullName();

            Console.WriteLine("Boss B status");

            HumanResources hr = new HumanResources();
            hr.FirstName ="Taylor";
            hr.LastName = "Johnson";
            hr.FullTimeId = 2001;

            SeasonalWorkers sw = new SeasonalWorkers();
            sw.FullTimeId = 7001;
            sw.FirstName = "Janet";

            Console.WriteLine("");

            Console.ReadLine();
            


        }
        
    }
    public class FullTimeEmployee : Employee
    {
        public double Salary;
        public double FullTimeId;

    }
    public class PartTimeEmployee : Employee
    {
        public double HourlyRate;
        public int PartTimeID;
    }
    public class SeasonalWorkers : FullTimeEmployee
    {
        public int SeasonID;
        public string Address;
        public string FirstName;
        

    }
    public class HumanResources : SeasonalWorkers
    {

    }
}
