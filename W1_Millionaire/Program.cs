using System;

namespace W1_Millionaire
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctAnswerCount = 0; // tracks correct user answers
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
                correctAnswerCount++;
            }

            Console.WriteLine();
            Console.WriteLine("2 -> Which is the smallest prime number?");
            Console.WriteLine("  a) 2");
            Console.WriteLine("  b) 1");
            Console.Write("Your answer: ");
            answer = char.Parse(Console.ReadLine().ToLower());
            if (answer == 'a')
            {
                correctAnswerCount++;
            }

            // checks correct answer count and continues as the conditions
            // 0 correct answer out of 2 -> lose condition & stop
            // 1 correct answer out of 2 -> continue to 3rd question
            // 2 correct answer out of 2 -> win condition & stop
            Console.WriteLine();
            if (correctAnswerCount < 1)
            {
                Console.WriteLine("Sorry, you lost. See you next time!");
            }
            else if (correctAnswerCount == 2)
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
                    correctAnswerCount++;
                }

                Console.WriteLine();
                if (correctAnswerCount >= 2)
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