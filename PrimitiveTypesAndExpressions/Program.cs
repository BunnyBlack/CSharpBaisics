using System;

namespace PrimitiveTypesAndExpressions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static void VariablesAndConstants()
        {
            var number = 2;
            var count = 1;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Mosh";
            var isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}",float.MinValue, float.MaxValue);
            
        }

        public static void TypeConversion()
        {
            byte i = 1;
            int j = i;
            int i2 = 1;
            byte j2 = (byte) i2;
            int i3 = 300;
            byte j3 = (byte) i3;        // 44
            string number = "1234";
            int num = Convert.ToInt32(number);
            int n = int.Parse(number);

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(i2);
            Console.WriteLine(j2);
            Console.WriteLine(i3);
            Console.WriteLine(j3);
            Console.WriteLine(num);
            Console.WriteLine(n);
        }
    }
}