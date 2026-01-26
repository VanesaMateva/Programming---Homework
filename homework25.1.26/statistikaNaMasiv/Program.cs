using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistikaNaMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 6 numbers: ");
            int[] numbers = new int[6];
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());
                numbers[i] = a;
                if (a < min)
                    min = a;
                if (a > max)
                    max = a;
                sum += a;
            }
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {sum / 6}");
        }
    }
}
