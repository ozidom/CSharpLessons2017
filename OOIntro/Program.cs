﻿using System;

namespace OOIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Steve";
           
            employee.DOB = new DateTime(2000,1,1);
            employee.PayRate = 60;
            int salary = employee.CalculatePay(30);

            Console.WriteLine($"{employee.Name} has earned ${salary} this fortnight and is {employee.Age} years old");

        }

	   /*In general, encapsulation is one of the four fundamentals of OOP(object-oriented programming). Encapsulation refers to the bundling of data with the methods that
        * operate on that data.[5] Encapsulation is used to hide the values or state of a structured data object inside a class, preventing unauthorized parties' direct
        * access to them. Publicly accessible methods are generally provided in the class (so-called getters and setters) to access the values, and other client classes 
        * call these methods to retrieve and modify the values within the object.*/

        // Task 4. Lets change the way we access each of our attributes and convert them to properties

        // Task 5. Lets change Age so that it returns an age based on the date of birth - we should also make sure that we cannot just change the Age whenever we want

        class Employee
        {
            public string Name { get; set; }
            public int Age 
            { 
                get
                {
					//https://stackoverflow.com/questions/3152977/calculate-the-difference-between-two-dates-and-get-the-value-in-years
					DateTime now = DateTime.Today;
					int age = now.Year - DOB.Year;
					if (DOB > now.AddYears(-age)) age--;

                    return age;

                }
            }
            public DateTime DOB { get; set; }
            public int PayRate{ get; set; }

            public int CalculatePay(int hoursWorked)
            {
                return PayRate * hoursWorked;
            }
        
        }
	}
}
