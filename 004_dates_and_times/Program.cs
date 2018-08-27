using System;

namespace _004_dates_and_times
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime myBirthDay = new DateTime(1981, 7, 10);
            var difference = now - myBirthDay;

            Console.WriteLine(difference.Days * 24);            
            Console.WriteLine(difference.Days);
            Console.WriteLine(difference.Days / 365 );

            DateTime someTime = new DateTime(2018, 8, 27, 19, 46, 31);
            DateTime newTime = someTime.AddMinutes(120);
            DateTime subTime = someTime.AddMinutes(-120);
            
            Console.WriteLine(someTime);
            Console.WriteLine(newTime);
            Console.WriteLine(subTime);

            Console.WriteLine(newTime.ToLongDateString());
            
        }
    }
}
