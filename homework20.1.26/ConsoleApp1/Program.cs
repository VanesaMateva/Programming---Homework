using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = 5740;
            int years = days / 365;
            int months = (days % 365) / 30;
            int day = (days % 365) % 30;
            int birthyear = 2025 - years;
            int birthmonth = 13 - months;
            int birthday = 40 - day;
            Console.WriteLine($"{birthday}.{birthmonth}.{birthyear}");
        }//ne znam dali e taka ama poluchih data
    }
}
