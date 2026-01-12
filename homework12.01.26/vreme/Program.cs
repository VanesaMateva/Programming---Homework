using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vreme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check the time: ");
            decimal time = decimal.Parse(Console.ReadLine());

            if (Math.Ceiling(time) == Math.Floor(time))
            {
               if (time > -129 && time < 128)
                    Console.WriteLine("It is sunny");
               else if (time > -2147483649 && time < 2147483648)
                    Console.WriteLine("It is cloudy");
               else
                    Console.WriteLine("It is windy");
            }
            else
                Console.WriteLine("It is rainy");
        }
    }
}
