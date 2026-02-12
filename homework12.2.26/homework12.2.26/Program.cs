using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12._2._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nums separated with a space:");
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> otriNums = new List<int>();
            List<int> chetNums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                    chetNums.Add(nums[i]);
                else 
                    otriNums.Add(nums[i]);
            }
            Console.WriteLine($"All even nums: {string.Join(", ", chetNums)}");
            Console.WriteLine($"All odd nums: {string.Join(", ", otriNums)}");
        }
    }
}
