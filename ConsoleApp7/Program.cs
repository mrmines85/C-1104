﻿using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "one weird trick";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }
        }
    }
}
