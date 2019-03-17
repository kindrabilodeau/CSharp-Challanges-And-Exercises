using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacoCat
{
    class Program
    {  
        //Test to see if string input is a palindrome.

        static void Main(string[] args)
        {
            string test1 = "tacocat";
            string test2 = "racecar";
            string test3 = "bingo";
            string test4 = "taco";
            string test5 = "box";
            string test6 = "evil olive";

            Pal(test1);
            Pal(test2);
            Pal(test3);
            Pal(test4);
            Pal(test5);
            Pal(test6);
        }

        private static void Pal(string test)
        {
            bool check = false;

            for (int i = 0, j = test.Length -1 ; i < test.Length; i++, j--)
            {
                if (test[i] == test[j])
                    check = true;
                else
                    check = false; 
            }

            Console.WriteLine($"{test} = {check}");
            Console.ReadLine();
        }
    }
}
