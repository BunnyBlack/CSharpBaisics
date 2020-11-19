using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ArrayMethod();

            // ListMethod();
        }


        public static void ArrayMethod()
        {
            var numbers = new int[] {3, 7, 9, 2, 14, 6};

            // Length
            Console.WriteLine(string.Format("Length: {0}", numbers.Length));

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(string.Format("Index of 9: {0}", index));

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear():");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Copy
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);
            Console.WriteLine("Effect of Copy():");
            foreach (var n in anotherArray)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort():");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse():");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void ListMethod()
        {
            var numbers = new List<int>() {1, 2, 3, 4};

            numbers.Add(1);
            numbers.AddRange(new[] {5, 6, 7});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine(string.Format("Index of 1: {0}", numbers.IndexOf(1)));
            Console.WriteLine(string.Format("Count: {0}", numbers.Count));
            Console.WriteLine(string.Format("Last Index of 1: {0}", numbers.LastIndexOf(1)));

            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(1);
                }
            }
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Clear();
            Console.WriteLine(numbers.Count);
            
            
        }
    }
}