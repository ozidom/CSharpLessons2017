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

            RandomBag<int> bag = new RandomBag<int>();
            bag.ChuckIn(3);
            bag.ChuckIn(33);
            bag.ChuckIn(43);
            bag.ChuckIn(16);
            bag.ChuckIn(317);
            bag.ChuckIn(89);

            Console.WriteLine($"{bag.Get()}");

        }

    }

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
