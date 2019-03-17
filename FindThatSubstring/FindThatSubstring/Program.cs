using System;

namespace FindThatSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //test cases:
            string test1 = "bingobingo";
            string test2 = "go";
            string test3 = "aaavv";
            string test4 = "av";

            int index = LookInside(test1, test2);
            int index1 = LookInside(test3, test4);
            Console.WriteLine($"Test 1: {index}");
            Console.WriteLine($"Test 2: {index1}");
            WriteAString();

        }

        /// <summary>
        /// Takes two string inputs
        /// </summary>
        private static void WriteAString()
        {
            Console.WriteLine("Please Enter The First String");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please Enter The Second String");
            string input2 = Console.ReadLine();
            int index2 = LookInside(input1, input2);
            Console.WriteLine($"{index2} ");
            Console.WriteLine("To Try Again Press 1, Press 2 to QUIT");
            int again = int.Parse(Console.ReadLine());
            if (again == 1)
                WriteAString();
        }
        /// <summary>
        /// looks at both strings, will determine if the second string
        /// is in the first string. 
        /// <param name="stringA"></param>
        /// <param name="stringB"></param>
        /// <returns>return the index </returns>
        private static int LookInside(string stringA, string stringB)
        {
            int stop = 0;
            int[] temp = new int[stringA.Length];

            for (int j = 0; j < stringA.Length; j++)
                for (int i = 0; i < stringB.Length; i++)
                {
                    if (stringA[j] == stringB[i])
                    {
                        temp[i] = j;
                        j++;
                        stop++;
                    }

                    else if (stringA[j] != stringB[i])
                    {
                        temp[j] = -1;
                        stop = 0;
                    }

                    if (stop == stringB.Length)
                        return temp[0];
                    else
                        temp[j] = -1; 
                }
            return temp[0];
        }
    }
}
