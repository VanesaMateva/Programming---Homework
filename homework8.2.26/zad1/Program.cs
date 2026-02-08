using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();//vyvewdat se elemntite na masiva na edin red razdeleni s space
            for (int i = arr.Length - 1; i >= 0; i--)//arr.Length-1 e posledniq indeks
            {
                Console.WriteLine($"{i}-и-- > {arr[i]}");//pehatim vyv vseki indeks kakyv element ima
            }
        }
    }
    
}
