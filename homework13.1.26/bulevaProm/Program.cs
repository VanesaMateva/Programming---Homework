using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulevaProm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter bool: ");
            bool input = bool.Parse(Console.ReadLine());
            if (input == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
