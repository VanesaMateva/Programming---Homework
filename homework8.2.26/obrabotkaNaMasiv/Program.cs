using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrabotkaNaMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyvedi masiv ot chisla razdeleni sys space: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 0, fIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int current = 0;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] + 1 == arr[j + 1])                   
                        current++;
                    else
                        break;
                }
                if (current > max)
                { 
                    max = current;
                    fIndex = i;
                }
            }
            Console.WriteLine("Naj-golamata veriga ot posledovatelni chisla:");
            for (int k = fIndex; k <= max + fIndex; k++)
            {
                Console.Write($"{arr[k]} ");
            }
            //iskah i pyrvata zadacha da q napravq no ne mowah da razbera uslovieto 
        }
    }
}
