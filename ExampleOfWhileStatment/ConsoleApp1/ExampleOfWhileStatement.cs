using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            int total = multiply(a, b);
            Console.ReadLine();
        }

        private static int multiply(int a, int b)
        {
            int c = 0;
            while(c < b)
            {
                int valuea = a + a;
                c++;
            }
            return a; 
        }
    }
}
