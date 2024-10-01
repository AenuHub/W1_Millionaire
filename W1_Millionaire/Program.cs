using System;

namespace W1_Millionaire
{
    class Program
    {
        static void Main(string[] args)
        {
            int answerCount = 0; // tracks correct user answers
            char answer; // holds user answer value

            Console.WriteLine("**** Welcome to 'Who wants to be a Millionaire?' quiz ****");
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("1 -> Which planet is known as the Red Planet?");
            Console.WriteLine("  a) Venus");
            Console.WriteLine("  b) Mars");
            Console.Write("Your answer: ");
            answer = char.Parse(Console.ReadLine().ToLower());
            if (answer == 'b')
            {
                answerCount++;
            }

            Console.WriteLine();
            Console.WriteLine("2 -> Which is the smallest prime number?");
            Console.WriteLine("  a) 2");
            Console.WriteLine("  b) 1");
            Console.Write("Your answer: ");
            answer = char.Parse(Console.ReadLine().ToLower());
            if (answer == 'a')
            {
                answerCount++;
            }

            Console.WriteLine();
            if (answerCount < 1)
            {
                Console.WriteLine("Sorry, you lost. See you next time!");
            }
            else if (answerCount == 2)
            {
                Console.WriteLine("Congrats! You have won the big prize of 1 Million $!");
            }
            else
            {
                Console.WriteLine("3 -> Which city is the capital of France?");
                Console.WriteLine("  a) Rome");
                Console.WriteLine("  b) Paris");
                Console.Write("Your answer: ");
                answer = char.Parse(Console.ReadLine().ToLower());
                if (answer == 'b')
                {
                    answerCount++;
                }

                Console.WriteLine();
                if (answerCount >= 2)
                {
                    Console.WriteLine("Congrats! You have won the big prize of 1 Million $!");
                }
                else
                {
                    Console.WriteLine("Sorry, you lost. See you next time!");
                }
            }
            
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}