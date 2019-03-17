using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose A Door");
            int choice = 0; 
            choose(choice);
        }

        private static void choose(int pickone)
        {
            Console.WriteLine("Door 1, Door 2, Door 3");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("You chose door 1. You found a Puppy!!!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("You chose door 2. You won a free lunch!!!");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You chose door 3. You found $100!!!!");
            }
            Console.WriteLine("Try again?");
            Console.WriteLine("Press 1 for yes, 2 for no");
            int again = int.Parse(Console.ReadLine());
            if (again == 1)
            {
                choose(choice);
            }
            else
                Environment.Exit(0);

        }
    }
}
