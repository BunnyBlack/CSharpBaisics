using System;

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
                float overSpeed = (float)((float)speed - (float)speedLimit);
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
    }
}