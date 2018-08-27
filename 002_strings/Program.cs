using System;

namespace _002_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string challenge = " Text processing in C# is really great! ";
            // get only "REALLY GREAT"

            string parsed = challenge.Trim().Substring(24, challenge.Trim().Length - 25).ToUpper();
            Console.WriteLine(parsed);

            string city = "Cape Town";
            DateTime currDate = DateTime.Now;
            float temp = 15f;

            string formatted1 = string.Format("Welcome to {0}, the date is {1} and the current temperature is {2}.", city, currDate, temp);
            string formatted2 = string.Format("Welcome to {0}, the time is {1:t} and the current temperature is {2}.", city, currDate, temp);
            string formatted3 = string.Format("Welcome to {0}, the time is {1:T} and the current temperature is {2:0.00}.", city, currDate, temp);

            Console.WriteLine(formatted1);
            Console.WriteLine(formatted2);
            Console.WriteLine(formatted3);

            string name = "Jeandre";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

        }
    }
}
