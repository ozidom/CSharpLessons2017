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
			//Like writing SQL like statements for all collections in C# ... but there is a really cool shorthand called Lambda Syntax

			/*
             A query is an expression that retrieves data from a data source.
             Queries are usually expressed in a specialized query language. 
             Different languages have been developed over time for the various types of data sources, 
             for example SQL for relational databases and XQuery for XML. 
             Therefore, developers have had to learn a new query language for each 
             type of data source or data format that they must support.
             LINQ simplifies this situation by offering a consistent model
             for working with data across various kinds of data sources and formats. 
             In a LINQ query, you are always working with objects. You use the same
             basic coding patterns to query and transform data in XML documents,
             SQL databases, ADO.NET Datasets, FileSystems, .NET collections, and any other 
             format for which a LINQ provider is available.
             */

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


			//References

			//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
			//http://theburningmonk.com/2010/02/linq-lambda-expression-vs-query-expression/

            //Homework

           // https://www.w3resource.com/csharp-exercises/linq/index.php

		}
    }
}
