using System;

namespace FindTheVowels
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String to find all the vowels in it");
            string input = Console.ReadLine();
            int numofvowels = VowelFinder(input);
            Console.WriteLine($"There are {numofvowels} vowels");
        }

        private static int VowelFinder(string input)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'E' };
            int count = 0;
            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < vowels.Length; j++)
                    if (input[i] == vowels[j])
                        count++;
            return count; 
        }
    }
}
