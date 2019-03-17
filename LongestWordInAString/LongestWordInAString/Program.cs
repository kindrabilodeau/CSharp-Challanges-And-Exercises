using System;

namespace LongestWordInAString
{
    public class LongestWord
    {
        //Goal:Find the largest word in a string, return that word 
        //If two are the same length, return the first word 
        //Ignore any punuation
        //Assume the input will not be empty 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String for the longest word:");
            string input = Console.ReadLine();
            string value = MaxString(input);
            Console.WriteLine($"Longest word is {value}");
        }

        //MaxString method returns a string
        //Returns the longest word
        public static string MaxString(string input)
        {
            string[] b = input.Split(' ', ',', '!', '&'); //splits each word on spaces,commas,! and &
            string max = b[0]; 

            for (int i = 0; i < b.Length; i++) //iterates through each element in the array
                if (max.Length < b[i].Length) //compares the first element in the array to the next one
                    max = b[i];              //if the next one is bigger, it assigns that to max and continues comparing
            return max;                      //returns the largest value 
        }
    }
}
