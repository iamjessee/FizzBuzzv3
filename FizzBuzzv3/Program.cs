﻿namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            // prompts user to enter an integer
            while (true)
            {
                Console.WriteLine("please enter a number for our divisibility range: ");
                string input = Console.ReadLine();
                
                // attempts to verify typed a valid integer 
                if (int.TryParse(input, out y))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number");
                }
            }
            // begins loop for user defined integer
            for (int x = 1; x <= y; x++)
            {              
                string output = "";
                Console.ForegroundColor = ConsoleColor.Green;
                // check divisibility by 3
                if (x % 3 == 0)
                {
                    output += "Fizz";
                }
                // check divisibility by 5
                if (x % 5 == 0)
                {
                    output += "Buzz";
                }
                // check divisibility by 7
                if (x % 7 == 0)
                {
                    output += "Bizz";
                }
                if (x % 11 == 0)
                {
                    output += "Fuzz";
                }
                // if output is empty adds number
                else if (output.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    output = x.ToString();
                }
                // prints output
                Console.WriteLine(output);
            }
        }
    }
}