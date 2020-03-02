using System;
using LeetSpeak;
using System.Collections.Generic;

namespace Program
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("Please type a sentence to be translated.");
            string userInput = Console.ReadLine();
            Translate translator = new Translate();
            Console.WriteLine(translator.LeetTranslate(userInput));
        }
    }
}