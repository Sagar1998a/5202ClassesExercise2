using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtain the information about the employee and save them to variables.
            Console.Write("Please enter the employee's first name: ");
            string fname = Console.ReadLine();
            Console.Write("Please enter the employee's last name: ");
            string lname = Console.ReadLine();
            Console.Write($"Please enter {fname}'s tax rate: ");
            double tax = double.Parse(Console.ReadLine());
            Console.Write($"Please enter {fname}'s Gross annual income: ");
            double gross = double.Parse(Console.ReadLine());

            //Create an employee object using the constructor and populating it with the variables where we saved the employees info.
            Employee p1 = new Employee(fname, lname, tax, gross);

            //Display the info back to the user using the empoyee object (p1)
            Console.WriteLine($"Name: {p1.Fname} {p1.Lname}\nTax: {p1.Tax}%\nGross Salary: {p1.Gross}\nNet Salary: {p1.Net()}");
        }
    }

    class Employee
    {
        //4 auto implemented properties, this is done by typing prop and pressing tab 2x
        public string Fname {  get; set; }
        public string Lname { get; set; }
        public double Tax { get; set; }
        public double Gross { get; set; }


        //Constructor, has the same name and capitilisation as the class name.
        public Employee(string _fname, string _lname, double _tax, double _gross)
        {
            Fname = _fname;
            Lname = _lname;
            Tax = _tax;
            Gross = _gross;
        }

        //Method to claculate the employees net salary( after tax)
        public double Net()
        {
            return Gross * (1 - Tax / 100);
        }
    }
}
