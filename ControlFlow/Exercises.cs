using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlFlow
{
    public class Exercises
    {
        public static void Exercise43_1()
        {
            int input;
            Console.WriteLine("Please enter a number between 1 to 10:");
            input = Convert.ToInt32(Console.ReadLine());
            if (input > 0 && input < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void Exercise43_2()
        {
            int number1;
            int number2;
            Console.WriteLine("Please enter two numbers:");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            var result = number1 > number2 ? number1 : number2;
            Console.WriteLine(string.Format("The bigger one is {0}", result));
        }

        public static void Exercise43_3()
        {
            int width;
            int height;

            Console.WriteLine("Please enter the width and height of a picture:");
            width = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToInt32(Console.ReadLine());
            var result = width > height ? "landscape" : "portrait";
            Console.WriteLine(string.Format("The image is {0}", result));
        }

        public static void Exercise43_4()
        {
            int speed;
            int speedLimit = 1;
            Console.WriteLine("Please enter the speed of the car:");
            speed = Convert.ToInt32(Console.ReadLine());
            if (speed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                float overSpeed = (float) ((float) speed - (float) speedLimit);
                int Quotient = (int) Math.Ceiling(overSpeed / 5);
                if (Quotient > 12)
                {
                    Console.WriteLine("License Suspended!");
                }
                else
                {
                    Console.WriteLine(string.Format("Demerit point is {0}", Quotient));
                }
            }
        }

        public static void Exercise49_1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public static void Exercise49_2()
        {
            var count = 0;
            Console.WriteLine("Please enter numbers to calculate sum and enter \"ok\" to exit:");
            while (true)
            {
                var readLine = Console.ReadLine();
                if (readLine == "ok")
                {
                    break;
                }
                else
                {
                    count += Convert.ToInt32(readLine);
                }
            }

            Console.WriteLine(count);
        }

        public static void Exercise49_3()
        {
            var number = 0;
            var factorial = 1;
            Console.WriteLine("Please enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i < number + 1; i++)
            {
                factorial *= i;
            }

            if (number == 0)
            {
                factorial = 1;
            }

            Console.WriteLine(string.Format("{0}! = {1}", number, factorial));
        }

        public static void Exercise49_4()
        {
            var random = new Random();
            var number = random.Next(1, 10);
            var chance = 4;
            var flag = false;
            for (var i = 0; i < chance; i++)
            {
                int input = 0;
                Console.WriteLine("Please guess:");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == number)
                {
                    flag = true;
                    break;
                }
            }

            Console.WriteLine(flag?"You won":"You lost");
            Console.WriteLine(string.Format("The number is {0}", number));
        }

        public static void Exercise49_5()
        {
            Console.WriteLine("Enter a series of numbers separated with comma:");
            var input = Console.ReadLine();

            var strList = input.Split(',');
            var resultList = new List<int>();
            foreach (var str in strList)
            {
                var number = Convert.ToInt32(str);
                resultList.Add(number);
            }

            Console.WriteLine(resultList.Max());
        }
    }
}