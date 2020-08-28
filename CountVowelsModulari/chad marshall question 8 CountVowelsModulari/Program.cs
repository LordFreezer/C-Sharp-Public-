///chad marshall qustion 8 chap 7 2/17/16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace chad_marshall_question_8_CountVowelsModulari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");/// asks user input
            string word = Console.ReadLine().ToLower();
            Console.WriteLine("The number of vowels in your word is: {0}", countVowels(word));/// output with method countVowels 
            Console.ReadLine();
        }
        public static int countVowels(string word)
        {
            int vowelCounter = 0;/// acumulator
            for (int x = 0; x < word.Length; x++)///for loop
            {
                if (word[x] == 'a' || word[x] == 'e' || word[x] == 'i' || word[x] == 'o' || word[x] == 'u')/// defineing vowels
                {
                    vowelCounter++;/// loop
                }
            }
            return vowelCounter;///return vowel counter
        }
    }
}
