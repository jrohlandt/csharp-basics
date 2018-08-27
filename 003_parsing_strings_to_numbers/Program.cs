using System;

namespace _003_parsing_strings_to_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string easy = "15";
            string complicated = "15,123";

            int easyParsed = int.Parse(easy);
            Console.WriteLine(easyParsed);
            
            int complicatedParsed;
            int.TryParse(complicated, out complicatedParsed);
            Console.WriteLine(complicatedParsed);
            
            Console.WriteLine(float.Parse(complicated));
        }
    }
}
