using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"arr1[{i}] = ");
                arr1[i] = int.Parse(Console.ReadLine());
                sum += arr1[i];
            }
            double avg = (double)sum / arr1.Length;
            Console.WriteLine($"Avg = {avg}");
            Console.Write("Enter a new num: ");
            int nnum = int.Parse(Console.ReadLine()); 
            Console.Write($"All elements from arr1 that are equal to {nnum}: "); 
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == nnum)
                    Console.Write($"arri[{i}], ");
            }
            Console.WriteLine("");
            for (int i = 0; i < arr1.Length; i++)
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
        }
    }
}
