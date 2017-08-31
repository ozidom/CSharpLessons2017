﻿﻿using System;

namespace OOIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Name = "Chris";

            manager.DOB = new DateTime(1982, 1, 1);
            manager.PayRate = 60;
            int salary = manager.CalculatePay(30);

            Console.WriteLine($"{manager.Name} has earned ${salary} this fortnight and is {manager.Age} years old");

        }

        //inheritance
        /*  In object-oriented programming, inheritance enables new objects to take on          * the properties of existing objects. A class that is used as the basis for inheritance          * is called a superclass or base class. A class that inherits from a superclass          * is called a subclass or derived class*/



        // Task 6. Lets add a class for Manger that inherits from Employee

        // Need to chat about Virtual methods - a Virtual method is a method that "can" be overridden

        // Task 7. Lets ensure that the CalculatePay method returns double the pervious calulated aount
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
            public int PayRate { get; set; }

            public virtual int CalculatePay(int hoursWorked)
            {
                return PayRate * hoursWorked;
            }
        }

        class Manager : Employee
        {
            public override int CalculatePay(int hoursWorked)
            {
                return base.CalculatePay(hoursWorked) * 2;
            } 
        }
    
	}
}
