using System;

namespace _001_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 5;
            short small = short.MaxValue; // 16 bit int
            int signed = int.MaxValue; // 32 bit int
            uint unsigned = uint.MaxValue; // 32 bit int
            long bigger = long.MaxValue; // 64 bit int
            ulong unsignedAndBig = ulong.MaxValue;
            float pi = 3.14f;
            double dd = 3.14;
            string greeting = "Hello World!";
            bool yes = true;
            bool no = false;


            Console.WriteLine(count);
            Console.WriteLine(small);
            Console.WriteLine(signed);
            Console.WriteLine(unsigned);
            Console.WriteLine(bigger);
            Console.WriteLine(unsignedAndBig);
            Console.WriteLine(pi);
            Console.WriteLine(dd);
            Console.WriteLine(greeting);

        }
    }
}
