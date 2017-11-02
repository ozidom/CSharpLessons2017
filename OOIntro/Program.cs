﻿﻿﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace OOIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq basics is looking at a collection of numbers
            List<int> numbers = new List<int> { 1, 4, 12, 3, 5, 6, 94, 34, 23, 4, 12, 5, 94 };
            PrintList(numbers, "Original");

            //Lets sort
            numbers.Sort();
            PrintList(numbers, "Sorted");

            //lets find the max number
            int max = numbers.Max();
            Console.WriteLine($"Max {max}");

            //Now lets get the number of items in the list
            int count = numbers.Count();
            Console.WriteLine($"Count {count}");

            //Lets add another list and see if we can do an distinct
            var distinct = numbers.Distinct();
            PrintList(distinct.ToList(), "Distinct from one list");

            //Lets add another list and see if we can do a union 
            List<int> moreNumbers = new List<int> { 11, 43, 12, 33, 53, 6, 934, 3334, 233 };
            var union = moreNumbers.Union(numbers);
            PrintList(union.ToList(), "Union");

            //Lets add another list and see if we can do a union (intersect)
            var intersect = moreNumbers.Intersect(numbers);
            PrintList(intersect.ToList(), "Intersect");

            Console.ReadLine();
        }

        static void PrintList(List<int> items, string title = "Another List")
        {
            Console.WriteLine(title);
            items.ForEach(i => Console.WriteLine(i));
        }
    }
}
