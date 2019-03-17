using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] x = new char[32];
            int purple = 16;
            int green = 16;
            Random r = new Random();
            Console.WriteLine($"Green:{green}, Purple:{purple}");
            for (int i = 0; i < x.Length; i++)
            {
                int m = r.Next() % 2;
                Console.Write($"{m}, ");
                if (m == 0 && purple > 0 || green == 0)
                {
                    x[i] = 'P';
                    purple--;
                }
                else if (m == 1 && green > 0 || purple == 0)
                {
                    x[i] = 'G';
                    green--;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
                Console.Write($"{x[i]}, ");
            Console.WriteLine();
            Console.WriteLine($"Green:{green}, Purple:{purple}");
        }
    }
}
