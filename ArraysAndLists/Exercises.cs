using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    public class Exercises
    {
        public static void Exercise56_1()
        {
            var nameList = new List<string>();

            Console.WriteLine("Please enter names:");
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                nameList.Add(input);
            }

            switch (nameList.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(string.Format("{0} likes your post.", nameList[0]));
                    break;
                case 2:
                    Console.WriteLine(string.Format("{0} and {1} like your post.", nameList[0], nameList[1]));
                    break;
                default:
                    Console.WriteLine(string.Format("{0}, {1} and {2} others like your post.", nameList[0], nameList[1],
                        (nameList.Count - 2)));
                    break;
            }
        }

        public static void Exercise56_2()
        {
            Console.WriteLine("Please enter your name:");
            var input = Console.ReadLine();
            var reverseName = input.ToCharArray();
            Array.Reverse(reverseName);
            Console.WriteLine(reverseName);
        }
        
        public static void Exercise56_3()
        {
            var numbers = new List<int>();

            Console.WriteLine("Please enter 5 unique numbers:");
            while (numbers.Count < 5)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Already contains: {0}, Please retry.", input);
                }
                else
                {
                    numbers.Add(input);
                }
            }
            Console.WriteLine();
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }

        public static void Exercise56_4()
        {
            var numbers = new List<int>();
            Console.WriteLine("Please enter numbers until enter \"Quit\"");

            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                var number = Convert.ToInt32(input);
                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }

            Console.WriteLine();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise56_5()
        {
            var numbers = new List<int>();
            Console.WriteLine("Please enter numbers separate with comma:");

            while (true)
            {
                var input = Console.ReadLine();
                var numberList = input.Split(',');
                foreach (var number in numberList)
                {
                    numbers.Add(Convert.ToInt32(number));
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List");
                    numbers.Clear();
                }
                else
                {
                    break;
                }
            }
            numbers.Sort();
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
    }
}