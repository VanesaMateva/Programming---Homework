using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter age: ");
            sbyte age = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter your gender(m/f): ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Enter your PID: ");
            long pid = long.Parse(Console.ReadLine());
            Console.Write("Enter your UEN: ");
            long uen = long.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {fname}\nLast name: {lname}\nAge: {age}\nGender: {gender}\nPersonal ID: {pid}\nUnique Employee number: {uen}");
        }
    }
}
