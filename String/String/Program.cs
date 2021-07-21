using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Programming today is a race between software engineers " +
            "striving to build bigger and better idiot-proof programs, and the universe trying to build " +
            "bigger and better idiots. So far, the universe is winning.";
            
            Console.WriteLine(sentence);
            Console.WriteLine();
            Console.WriteLine("What word would you like to look for in the above sentence?");
            string look = Console.ReadLine();
           
            Console.WriteLine($"What word would you like to change ({look}) to?");
            string newWord = Console.ReadLine();

            if (sentence.Contains(look) == false)
            {
                Console.WriteLine($"Sorry, I could not find your word: {look}.");
                for (int i = look.Length-1; i >= 0; i--)
                {
                    Console.WriteLine(look[i]);
                }
            }
            if (sentence.Contains(look) == true)
            {
                Console.WriteLine(sentence.Replace(look, newWord));
            }

            
        }
    }
}
