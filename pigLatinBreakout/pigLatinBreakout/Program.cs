using System;
using System.Linq;

namespace pigLatinBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This game will translate words you input into Pig Latin!\n");
            Console.Write("Please input a word: ");

            string input = Console.ReadLine().ToLower();
            char[] word = input.ToArray();

            bool isSkip = false;
            
            //Checking for numbers
            foreach(char letter in word)
            {
                bool isNum = isNumber(letter);
                
                if (isNum == true)
                {
                    isSkip = true;
                    break;
                }
            }

            bool isFirstLetterVowel = isVowel(word[0]);
            if (isSkip == false)

            if (isFirstLetterVowel)
            {
                Console.WriteLine("Pig Latin translation is: " + input + "way");
            }

            else
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                int index = input.IndexOfAny(vowels);
                
                string prefix = input.Substring(index);
                string postfix = input.Substring(0, index) + "ay";
                Console.WriteLine("Pig Latin translation is: " + prefix + postfix);
;           }

            else
            {
                Console.WriteLine("your word cannot be translated into pig latin!");
            }
        }

        public static bool isVowel (Char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            bool output = vowels.Contains(c);

            return output;
        }

        public static bool isNumber (Char c)
        {
            bool output = char.IsNumber(c);
            return output;
        }
    }
}
