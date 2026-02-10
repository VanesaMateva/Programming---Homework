using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10._2._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2a
            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("Yellow");
            colorList.Add("Purple");
            colorList.Add("Orange");

            //2b
            string[] b = { "Red", "Green", "Yellow" };            
            colorList.AddRange(b);

            //4
            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("Yellow");
            colorList.Add("Purple");
            colorList.Add("Orange");
            Console.WriteLine(colorList[1]);//???
            colorList[2] = "Indigo";
            foreach (string color in colorList)
                Console.WriteLine(color);
            for (int i = 0; i < colorList.Count; i++)
                Console.WriteLine(colorList[i]);
        }
    }
}
