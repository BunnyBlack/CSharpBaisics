using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

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
            if (!String.IsNullOrEmpty(input))
            {
                var isDuplicate = CheckIfDuplicate(input);

                Console.WriteLine(isDuplicate?"Duplicate":"");
            }
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
    }
}