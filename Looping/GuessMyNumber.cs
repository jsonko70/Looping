using System;
using System.Collections.Generic;
using System.Text;

namespace Looping
{
    class GuessMyNumber
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int hidden;
            int guessedNumber;
            string playAgain;
            string strHotCold;

             do
            {
                hidden = rand.Next(100);
                guessedNumber = Utils.GetNumber("Guess a number between 0 and 100: ", 100);

                while (true)
                {
                    int diff = Math.Abs(guessedNumber) - Math.Abs(hidden);
                    if (diff > 10)
                    {
                        strHotCold = "You're as cold as ice!";
                    }
                    else if (diff > 5)
                    {
                        strHotCold = "You're getting warm!";
                    }
                    else if (diff > 3)
                    {
                        strHotCold = "You're getting hot!";
                    }
                    else
                    {
                        strHotCold = "You're on Fire!!";
                    }
                    if (guessedNumber > hidden)
                    {
                        Console.WriteLine("Your guessed number is greater than my hidden number");
                        Console.WriteLine(strHotCold);
                    }
                    else if (guessedNumber < hidden)
                    {
                        Console.WriteLine("Your guessed number is lower than my hidden number");
                        Console.WriteLine(strHotCold);
                    }
                    else
                    {
                        Console.WriteLine("Your guessed number is correct! WINNER!");
                        playAgain = Utils.GetInput("Would you like to play again? (Y for Yes): ");
                        break;
                    }
                    guessedNumber = Utils.GetNumber("Guess a number between 0 and 100: ", 100);
                }
            }
            while (playAgain.ToUpper() == "Y");
        }

    }
}
