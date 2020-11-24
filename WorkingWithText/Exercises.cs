using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WorkingWithText
{
    public class Exercises
    {
        public static void Exercise68_1()
        {
            Console.WriteLine("Please enter numbers separate with hyphen:");
            var input = Console.ReadLine();
            var isConsecutive = CheckIfConsecutive(input);

            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }

        public static void Exercise68_2()
        {
            Console.WriteLine("Please enter numbers separate with hyphen:");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return;
            var isDuplicate = CheckIfDuplicate(input);

            Console.WriteLine(isDuplicate ? "Duplicate" : "");
        }

        public static void Exercise68_3()
        {
            Console.WriteLine("Please enter a time value in the 24-hour time format:");
            var input = Console.ReadLine();
            var isValidTime = CheckIfValidTime(input);

            Console.WriteLine(isValidTime ? "Ok" : "Invalid Time");
        }

        public static void Exercise68_4()
        {
            Console.WriteLine("Please enter some words separate with space:");
            var input = Console.ReadLine();
            var pascalCase = ChangeToPascalCase(input);
            Console.WriteLine(pascalCase);
        }

        public static void Exercise68_5()
        {
            Console.WriteLine("Please enter an English word:");
            var input = Console.ReadLine();
            var count = GetVowelCount(input);
            Console.WriteLine(count);
        }

        private static int GetVowelCount(string input)
        {
            var regex = new Regex("[aeiouAEIOU]");
            var matches = regex.Matches(input);
            return matches.Count;
        }


        private static bool CheckIfConsecutive(string input)
        {
            var isConsecutive = false;
            var strList = input.Split('-');
            var numbers1 = new List<int>();
            var numbers2 = new List<int>();

            foreach (var s in strList)
            {
                numbers1.Add(Convert.ToInt32(s));
                numbers2.Add(Convert.ToInt32(s));
            }

            numbers2.Sort();
            if (numbers1.SequenceEqual(numbers2))
            {
                isConsecutive = true;
            }
            else
            {
                numbers2.Reverse();
                if (numbers1.SequenceEqual(numbers2))
                {
                    isConsecutive = true;
                }
            }


            return isConsecutive;
        }

        private static bool CheckIfDuplicate(string input)
        {
            var isDuplicate = false;
            var strList = input.Split('-');
            var numbers = new List<int>();

            foreach (var s in strList)
            {
                numbers.Add(Convert.ToInt32(s));
            }

            numbers.Sort();

            isDuplicate = (numbers[0] == numbers[numbers.Count - 1]);
            return isDuplicate;
        }

        private static bool CheckIfValidTime(string input)
        {
            var isValid = true;
            var timeList = input.Split(':');
            var times = new List<int>();

            foreach (var s in timeList)
            {
                times.Add(Convert.ToInt32(s));
            }

            if (times[0] < 0 || times[0] > 23)
            {
                isValid = false;
            }

            if (times[1] < 0 || times[1] > 59)
            {
                isValid = false;
            }


            return isValid;
        }

        private static string ChangeToPascalCase(string input)
        {
            var strList = input.Split(' ');
            var variableList = new List<string>();

            foreach (var s in strList)
            {
                var temp = s.ToLower();
                var c = temp.ToArray();
                c[0] = (char) (c[0] - 32);
                temp = String.Join("", c);
                variableList.Add(temp);
            }

            return String.Join("", variableList);
        }
        
        
    }
}

