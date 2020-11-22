using System;

namespace WorkingWithDates
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // DateTimeMethod();

            // TimeSpanMethod();
        }

        private static void TimeSpanMethod()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine(string.Format(format: "Duration: {0}", duration));

            // Properties
            Console.WriteLine(string.Format("Minutes: {0}", timeSpan.Minutes));
            Console.WriteLine(string.Format("TotalMinutes: {0}", timeSpan.TotalMinutes));

            // Add
            Console.WriteLine(string.Format("Add Example: {0}", timeSpan.Add(TimeSpan.FromMinutes(8))));
            Console.WriteLine(string.Format("Substract Example: {0}", timeSpan.Subtract(TimeSpan.FromMinutes(8))));

            // ToString
            Console.WriteLine(string.Format("ToString: {0}", timeSpan.ToString()));
            Console.WriteLine(string.Format("Parse: {0}", TimeSpan.Parse("01:02:03")));
        }

        public static void DateTimeMethod()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Second: " + now.Second);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("MM/dd/yyyy"));
        }
    }
}