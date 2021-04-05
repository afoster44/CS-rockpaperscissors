using System;

namespace rps
{
    class Program
    {
        static string[] compChoices = new string[3]{
                "Rock",
                "Paper",
                "Scissors"
            };

        static int playerWins = 0;
        static int compWins = 0;
        //after testing hard coded choice for rock we can then give compChoice[rndNum]

        static void Main(string[] args)
        {

            Console.Clear();
            bool playing = true;
            while (playing)
            {
                Console.WriteLine(@"
Please select a choice from below:                
(R)ock
(P)aper
(S)cissors
(E)xit the game because life happens!");
                ConsoleKeyInfo userInput = Console.ReadKey();
                Random rnd = new Random();
                int rndNum = rnd.Next(0, 3);
                string compChoice = compChoices[rndNum];
                // string compChoice = compChoices[0];
                Console.Clear();
                //testing actual choices
                // Console.WriteLine($"{userInput.Key} {rndNum}");
                if (userInput.Key == ConsoleKey.R && compChoice == compChoices[0])
                {
                    Console.WriteLine($@"Phew it was a tie this time");
                }
                else if (userInput.Key == ConsoleKey.P && compChoice == compChoices[0])
                {
                    playerWins++;
                    Console.WriteLine($@"Hey you won!
You played: {userInput.Key}
Computer played: {compChoice}
Player score: {playerWins}
Computer score: {compWins}");
                }
                else if (userInput.Key == ConsoleKey.S && compChoice == compChoices[0])
                {
                    compWins++;
                    Console.WriteLine($@"Sorry you lost!
You played: {userInput}
Computers played: {compChoice}
Player score: {playerWins}
Computer score: {compWins}");
                }
                else if (userInput.Key == ConsoleKey.P && compChoice == compChoices[1])
                {
                    Console.WriteLine($@"Phew it was a tie this time");
                }
                else if (userInput.Key == ConsoleKey.S && compChoice == compChoices[1])
                {
                    playerWins++;
                    Console.WriteLine($@"Hey you won!
You played: {userInput.Key}
Computer played: {compChoice}
Player score: {playerWins}
Computer score: {compWins}");
                }
                else if (userInput.Key == ConsoleKey.R && compChoice == compChoices[1])
                {
                    compWins++;
                    Console.WriteLine($@"Sorry you lost!
You played: {userInput}
Computers played: {compChoice}
Player score: {playerWins}
Computer score: {compWins}");
                }
                else if (userInput.Key == ConsoleKey.S && compChoice == compChoices[2])
                {
                    Console.WriteLine($@"Phew it was a tie this time");
                }
                else if (userInput.Key == ConsoleKey.R && compChoice == compChoices[2])
                {
                    playerWins++;
                    Console.WriteLine($@"Hey you won!
You played: {userInput.Key}
Computer played: {compChoice}
Player score: {playerWins}
Computer score: {compWins}");
                }
                else if (userInput.Key == ConsoleKey.P && compChoice == compChoices[2])
                {
                    compWins++;
                    Console.WriteLine($@"Sorry you lost!
You played: {userInput}
Computers played: {compChoice}
Player score: {playerWins}
Computer score: {compWins}");
                }
                else if (userInput.Key == ConsoleKey.E)
                {
                    Console.WriteLine("Thanks for Playing!");
                    playing = false;
                }
            }
        }
    }
}
