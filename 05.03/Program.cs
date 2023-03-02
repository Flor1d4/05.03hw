using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 7;
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}"); 
            string x = "Swap";
            string y = "Properties";
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}"); 
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
