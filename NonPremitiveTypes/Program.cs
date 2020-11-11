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

            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine((ShippingMethod)method);
            Console.WriteLine((int)method);
            Console.WriteLine(method.ToString());
            
        }
    }
}