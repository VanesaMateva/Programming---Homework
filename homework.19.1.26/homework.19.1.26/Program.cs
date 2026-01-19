using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework._19._1._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name(or whatever you want): ");
            string something = Console.ReadLine();
            Console.WriteLine($"The length of the name/word you entered is: {something.Length}");
            Console.WriteLine($"All capitals: {something.ToUpper()}"); 
        }
    }
}
