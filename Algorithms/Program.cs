﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] numbers = new int[10];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 10);
            }

            foreach (int x in Sorting.BubbleSort(numbers))
            {
                Console.WriteLine(x);
            }

            //Console.WriteLine();

            //foreach (int x in Sorting.InsertionSort(numbers))
            //{
            //    Console.WriteLine(x);
            //}

            Console.WriteLine("\nSearch");

            Console.WriteLine(Searching.BinarySearch(numbers, 5));

            Console.Read();
        }
    }
}
