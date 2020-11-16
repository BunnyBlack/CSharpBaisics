using System;

namespace ControlFlow
{
    internal class Program
    {
        public static void Main(string[] args)
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
            
        }
    }
}