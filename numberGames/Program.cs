using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            string username;
            string welcomeMessage = "Hi, what's your name?";
            Console.WriteLine(welcomeMessage);
            string name = Console.ReadLine();
            if (name.Length > 0)
            {
                username = name;
            }
            else
            {
                username = "friend";
            }
            Random rand = new Random();
            int startingNumber = rand.Next(1, 100);
            Boolean gameContinue = true;
            string startingNumberAsk = $"Hi, {username}! Let's start with {startingNumber}.\nIs the next one going to be higher or lower?";
            Console.WriteLine(startingNumberAsk);
            int previousNumber = startingNumber;
            int nextNumber = rand.Next(1, 100);

            int points = 0;

            while (gameContinue)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "higher")
                {
                    if (nextNumber >= previousNumber)
                    {
                        points++;
                        Console.WriteLine($"You got it right, it was higher! Your score is {points}. Keep going! Is the next number higher or lower than {nextNumber}?");
                        previousNumber = nextNumber;
                        nextNumber = rand.Next(1, 100);
                    }
                    else
                    {

                        gameContinue = false;
                    }
                }
                else if (answer == "lower")
                {
                    if (nextNumber <= previousNumber)
                    {
                        points++;
                        Console.WriteLine($"You got it right, it was lower! Your score is {points}. Keep going! Is the next number higher or lower than {nextNumber}?");
                        previousNumber = nextNumber;
                        nextNumber = rand.Next(1, 100);
                    }
                    else
                    {
                        gameContinue = false;
                    }
                }
                else
                {
                    Console.WriteLine("Pick a valid answer, higher or lower.");
                }
                
            }

            Console.WriteLine($"You got it wrong. The next number was {nextNumber}. Your final score is {points}.");
            Console.ReadLine();
        }
    }
}