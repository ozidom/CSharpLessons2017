﻿﻿﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OOIntro
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Suburb { get; set;  }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Intro to Linq");

            //Linq is my favourite feature in C# :)
            //Language INtegrated Query
            //Like writing SQL like statements for all collections in C#

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name = "chris j", Salary = 300000m, Suburb = "Hawker" });
            employees.Add(new Employee { Name = "dom", Salary = 50000m, Suburb = "Unsafe Florey" });
            employees.Add(new Employee { Name = "santa", Salary = 10m, Suburb = "North Pole" });













            Console.WriteLine("In the time before linq");
            //task 1 find the persons in Hawker
            List<Employee> employeesInHawker = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Suburb == "Hawker")
                {
                    employeesInHawker.Add(employee);
                }
            }

            foreach (Employee employeeHawker in employeesInHawker)
            {
                Console.WriteLine($"{employeeHawker.Name}");
            }
















            //Two forms of LINQ 
            //1. QuerySyntax
            //2. Lambda

            //task 2 Write in Query Syntax
            Console.WriteLine("Linq Query Syntax");
            var employeesInHawkerLinqQuerySyntax = 
                        from e
                        in employees
                        where e.Suburb == "Hawker"
                         select e;

            foreach (Employee employeeHawker in employeesInHawkerLinqQuerySyntax)
            {
                Console.WriteLine($"{employeeHawker.Name}");
            }











            //task 3 - write in Lambda
            Console.WriteLine("Linq Lambda Syntax");
            //lets write it using Lambda syntx
            var employeesInHawkerLinqQueryLambda = employees.Where(e => e.Suburb == "Hawker");

            foreach (Employee employeeHawkerLambda in employeesInHawkerLinqQueryLambda)
            {
                Console.WriteLine($"{employeeHawkerLambda.Name}");
            }

        }
    }
}
