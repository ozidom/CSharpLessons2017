﻿﻿﻿using System;

namespace OOIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            const int basePayRate = 50;
            Console.WriteLine("Pick the type of Worker: 1.Employee 2.Manager and 3.Junior");
            int employeeTypeID = int.Parse(Console.ReadLine());
            BaseEmployee employee;
            switch (employeeTypeID)
            {
                case 1:
                    employee = new Employee();
                    break;
				case 2:
					employee = new Manager();
					break;
				case 3:
					employee = new Junior();
					break;
                default:
                    employee = null;
                    break;
            }

            if (employee is null)
                throw new Exception("Invalid Employee Type");
                

			Console.WriteLine("Enter the Name");
            string name =  Console.ReadLine();
            employee.Name = name;

			Console.WriteLine("Enter the Hours Worked");
			int hoursWorked = int.Parse(Console.ReadLine());

            employee.PayRate = basePayRate;

            int salary = employee.CalculatePay(hoursWorked);

            Console.WriteLine($"{employee.Name} has earned ${salary} this fortnight");

        }

		//Polymorphism
		/*  The word ‘polymorphism’ literally means ‘a state of having many shapes’ or ‘the capacity to take on different forms’. 
		 * When applied to object oriented programming languages like Java, it describes a language’s ability to process objects
		 * of various types and classes through a single, uniform interface. 
        https://www.sitepoint.com/quick-guide-to-polymorphism-in-java/ */

		//We want to talk about a keyword called "Abstract". To mark a class abstract mean you cannot instantiate it. It's pretty cool though becasue
        //you can have methods and properties that can be used by sub-classes of an abstract class 
		//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract

		// Task 8 We want to support a new type of employee - a junior who gets paid 0.8 of a salary. Lets add another class that inherits from employee

        // Task 9 So lets add some code to ask the user to pick the type of employee and their Name and based on that selection calculate the salary
        // In this task lets assume the company has a base pay of $50 an hour. We wont worry about DOB and Age in this example but we can leave the implementation
        // for a later date.

		abstract class BaseEmployee
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
            public int PayRate { get; set; }

            public virtual int CalculatePay(int hoursWorked)
            {
                return PayRate * hoursWorked;
            }
        }

        class Manager : BaseEmployee
        {
            public override int CalculatePay(int hoursWorked)
            {
                return base.CalculatePay(hoursWorked) * 2;
            }
        }

        class Junior : BaseEmployee
        {
			public override int CalculatePay(int hoursWorked)
			{
                //https://stackoverflow.com/questions/501090/how-do-i-convert-a-decimal-to-an-int-in-c
				return Convert.ToInt32(base.CalculatePay(hoursWorked) * 0.8);
			}
        }

		class Employee : BaseEmployee
		{
			
		}
    
    
	}
}
