using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 123;
            
            int acc = 0; 
            while (n > 0 )
            {
                acc += n % 10;
                n = n / 10;
            }
            Console.WriteLine($"{acc}"); 
        }
    }
}
