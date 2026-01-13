using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many people are going on the elevator: ");
            int people = int.Parse(Console.ReadLine());
            Console.Write("Enter how many people the elevator can take at once: ");
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)people / capacity);
            Console.WriteLine($"It'll take {courses} trips");
        }
    }
}
