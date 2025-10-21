using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework22._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaqa za namiraneto na obikolkata i perimetyra na triygylnik");
            Console.WriteLine("Vuvedete duljinite na stranite na triygylnika:");
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());
            Console.Write("ha = ");
            var ha = double.Parse(Console.ReadLine());
            var P = a + b + c;
            var S = a * ha / 2;
            Console.WriteLine("Obikolkata na triygylnika e = " + P);
            Console.WriteLine("A liceto na triygylnika e = " + S);
        }
    }
}
