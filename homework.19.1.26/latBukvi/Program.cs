using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latBukvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num - 1; i++)
            {
                for (int j = 0; j <= num - 1; j++)
                {
                    for (int v = 0; v <= num - 1; v++)
                    {
                        char first = (char)('a' + i);
                        char second = (char)('a' + j);
                        char third = (char)('a' + v);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}