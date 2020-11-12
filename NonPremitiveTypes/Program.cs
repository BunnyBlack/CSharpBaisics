using System;
using NonPremitiveTypes.Math;

namespace NonPremitiveTypes
{
    public enum ShippingMethod
    {
        RegularAirMail = 0,
        RegisteredAirMail = 1,
        Express = 2
    }

    public struct RGBColor
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var john = new Person {FirstName = "John", LastName = "Smith"};
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var name = new string[3] {"Jack", "John", "Mary"};

            var names = string.Format("{0} {1} {2}", name[0], name[1], name[2]);
            var names1 = string.Join(", ", name);
            Console.WriteLine(names);
            Console.WriteLine(names1);


            var str0 = "abc\n";
            var str1 = @"abc\n";

            Console.WriteLine(str0);
            Console.WriteLine(str1);

            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            var methodId = 2;
            Console.WriteLine((ShippingMethod) methodId);
            Console.WriteLine((int) method);
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine((int) shippingMethod);

            var a = 1;
            var b = a;
            b++;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            var arr = new int[3] {1, 1, 1};
            var arr1 = arr;
            arr1[0] = 0;
            Console.WriteLine("arr[0] = {0}, arr1[0] = {1}", arr[0], arr1[0]);
        }
    }
}