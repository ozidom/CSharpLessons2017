﻿﻿﻿using System;
using System.Collections.Generic;

namespace OOIntro
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Start of Intro to Linq");

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name = "chris j", Salary = 300000m });
			employees.Add(new Employee { Name = "dom", Salary = 50000m });
			employees.Add(new Employee { Name = "santa", Salary = 10m });

            //task 1 find the person with the salary highest - please don't use linq for this
            int highestSalary = 0;
            Employee highestPaid = null;
            foreach(Employee employee in employees)
            {
                if (employee.Salary > highestSalary)
                {
                    highestPaid = employee;
                }
            }
            Console.WriteLine($"The highest paid person is {highestPaid.Name}");
            //task 2



            //So thats pretty cool lets try something a bit funkier


            Console.WriteLine("End of Intro to Linq");
        }
	}
}
