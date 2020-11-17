using System;

namespace ControlFlow
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // IfElseStatement();

            // SwitchCaseStatement();

            // ForStatement();

            // ForeachStatement();

            // RandomClass();
            
            // Exercises.Exercise43_1();
            
            // Exercises.Exercise43_2();
            
            // Exercises.Exercise43_3();
            
            // Exercises.Exercise43_4();
        }

        public static void RandomClass()
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(random.Next(1, 10));
            }

            Console.WriteLine();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char) ('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }

        public static void ForeachStatement()
        {
            var name = "John Smith";
            foreach (var ch in name)
            {
                Console.WriteLine(ch);
            }

            var numbers = new int[4] {1, 2, 3, 4};
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void ForStatement()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 10; i > -1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "John Smith";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        public static void SwitchCaseStatement()
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                {
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                }
                case Season.Summer:
                {
                    Console.WriteLine("It's perfect to go to beach");
                    break;
                }
                default:
                {
                    Console.WriteLine("I don't understand that season!");
                    break;
                }
            }

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                {
                    Console.WriteLine("We've got promotion!");
                    break;
                }
                default:
                {
                    Console.WriteLine("I don't understand that season!");
                    break;
                }
            }
        }

        public static void IfElseStatement()
        {
            var hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            var price = 0f;
            var isGoldCustomer = true;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            price = isGoldCustomer ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}