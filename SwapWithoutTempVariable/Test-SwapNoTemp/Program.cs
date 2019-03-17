using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SwapNoTemp
{
    class Program
    {    //Goal: swap two numbers 
         //Without using a temporary variable 
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;
            Console.WriteLine($"Before: a ={a} b = {b}");
            a = b + a;
            b = a - b;
            a = a - b; 
            Console.WriteLine($"After: a = {a} b = {b}");
            Console.ReadLine();

        }
    }
}
