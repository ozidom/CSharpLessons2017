﻿﻿﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OOIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Generics are the most powerful feature of C# 2.0. Generics allow you to define type-safe data structures,
             *without committing to actual data types. This results in a significant performance boost and higher quality
             *code, because you get to reuse data processing algorithms without duplicating type-specific code
            *https://msdn.microsoft.com/en-us/library/ms379564(v=vs.80).aspx
            */
            List<int> numbers = new List<int>() { 3, 42, 3, 5, 5, 3, 3, };
            List<string> words = new List<string>() { "the", "big", "list", "of", "z", "numbers" };

            int maxNumber = numbers.Max();
            string maxWord = words.Max();

            Console.WriteLine($"{maxNumber}");
            Console.WriteLine($"{maxWord}");

            //Now lets look at how we can create a Generic Class
            RandomBag<int> bag = new RandomBag<int>();
            bag.ChuckIn(3);
            bag.ChuckIn(33);
            bag.ChuckIn(43);
            bag.ChuckIn(16);
            bag.ChuckIn(317);
            bag.ChuckIn(89);

            //OK so we used it for ints and that works well but how
            //bout we use it now for say strings
			RandomBag<string> stringBag = new RandomBag<string>();
			stringBag.ChuckIn("Chris");
			stringBag.ChuckIn("Johnson");
			stringBag.ChuckIn("is");
			stringBag.ChuckIn("a really");
			stringBag.ChuckIn("realy cool");
			stringBag.ChuckIn("guy");

            Console.WriteLine($"{bag.Get()}");
            Console.WriteLine($"{stringBag.Get()}");

			//Homework
			//1. Can you think of a cool way to use the random bag to implement a dice

			//2. Write a Generic Class called ModeCollection to return the most popular member (think statistics: Mode)  of a collection
			/*
             * Mode (statistics) The mode of a set of data values is the value that appears most often. 
             * It is the value x at which its probability mass function takes its maximum value. 
             * In other words, it is the value that is most likely to be sampled.
             * https://en.wikipedia.org/wiki/Mode_(statistics)
            */

			//MORE
			//https://www.youtube.com/watch?v=gyal6TbgmSU


		}

    }

    //This is a classic 
    class RandomBag<T>
    {
        List<T> bag = new List<T>();
        public RandomBag()
        {
            bag = new List<T>();
        }
       
        public void ChuckIn(T item)
        {
            bag.Add(item);
        }

        public T Get()
        {
            var r = new Random();
            int i = r.Next(bag.Count);
            return bag[i];
        }


    }

}
