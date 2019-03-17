using System;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int n = Convert.ToInt32(Console.ReadLine());
            MakeStairCase(n);
            Console.ReadLine();
        }

        private static void MakeStairCase(int n)
        {
            int t = n;
            int g = 0;

            while (n > 0)
            {
                int x = 0; 
                t = n;    
                g++;   
                while (t > 0)   
                {
                    t--;   
                    Console.Write(' ');
                }
                while (x < g)
                {
                    Console.Write("#");
                    x++;
                }
                Console.WriteLine();
                n--;
            }
        }
    }
}
