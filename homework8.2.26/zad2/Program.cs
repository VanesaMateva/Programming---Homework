using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double min = 1000, max = -1000, sum = 0;
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();//deklarirane na masiv i se vyvewdat elementite sys space

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (arr[i] < min) min = arr[i];//prverqvame vseki element i pazim naj-malkiq v min
                if (arr[i] > max) max = arr[i];//syshtoto no e za max
            }
            Console.WriteLine(min);//pechatim naj-malkiqt element kojto e v min
            Console.WriteLine(max);//pechatim naj-golemiat kojto e v max
            Console.WriteLine(sum);//pechatim sumata na vsichki elementi
            Console.WriteLine(sum / arr.Length);//sredno aretmetichno
        }
    }
}
