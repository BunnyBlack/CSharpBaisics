using System;
using System.Text;

namespace WorkingWithText
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // StringMethod();

            // SummarisingTest();

            // StringBuilderMethod();
            
            // Exercises.Exercise68_1();
            
            // Exercises.Exercise68_2();
            
            // Exercises.Exercise68_3();
            
            // Exercises.Exercise68_4();
            
            // Exercises.Exercise68_5();
        }

        public static void StringBuilderMethod()
        {
            var builder = new StringBuilder();
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine("FirstChar: {0}", builder[0]);
        }

        private static void SummarisingTest()
        {
            var sentence = "This is going to be a really really really really really long text.";

            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }

        public static void StringMethod()
        {
            var fullName = "Mosh Hamedani ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: {0}", firstName);
            Console.WriteLine("LastName: {0}", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: {0}", names[0]);
            Console.WriteLine("LastName: {0}", names[1]);

            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh"));
            Console.WriteLine(String.IsNullOrEmpty(null));
            Console.WriteLine(String.IsNullOrEmpty(""));
            Console.WriteLine(String.IsNullOrEmpty(" "));
            Console.WriteLine(String.IsNullOrEmpty(" ".Trim()));
            Console.WriteLine(String.IsNullOrWhiteSpace(" "));

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            var price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
        }
    }
}