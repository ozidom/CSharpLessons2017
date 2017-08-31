using System;

namespace OOIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Steve";
            employee.Age = 17;
            employee.DOB = new DateTime(2000,1,1);
            employee.PayRate = 60;
            int salary = employee.CalculatePay(30);

            Console.WriteLine($"{employee.Name} has earned ${salary} this year");

        }

        /*
         *  Through the process of abstraction, a programmer hides all but the relevant data about an object in order to reduce complexity and increase efficiency.
         * In the same way that abstraction sometimes works in art, the object that remains is a representation of the original, with unwanted detail omitted.
         * The resulting object itself can be referred to as an abstraction, meaning a named entity made up of selected attributes and behavior specific to a particular 
         * usage of the originating entity.
         */

        // Task 1. Lets create an Employee class that abstracts an employee

        // Task 2. Lets adds a few attribues Name, Age, DOB, PayRate

        // Task 3. Lets add a method to calculatePay by passing it the hours worked

        class Employee
        {
            public string Name;
            public int Age;
            public DateTime DOB;
            public int PayRate;

            public int CalculatePay(int hoursWorked)
            {
                return PayRate * hoursWorked;
            }
        
        }
	}
}
