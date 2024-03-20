using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel;
using System.Xml.Resolvers;
using System;

namespace RPS_Game
{
    internal class Program
    {
        static void Main(string[] args)
         {
            start:
            string nickname;
            string startChoice;
            int age = 0;
            int totalRounds = 0;
            int wins = 0;   
            void playerInfo()
            {
                Console.Clear();
                Console.WriteLine($" Nickname: {nickname} \n Age: {age} \n Played rounds: {totalRounds} \n Wins: {wins}");
            }

            Console.Write("Write your nickname: ");
            nickname = Console.ReadLine();
            Console.Write("Write your age: ");
            age = int.Parse(Console.ReadLine());
            if (age < 12)
            {
                Console.WriteLine("You are very young. Try later when you are older");
                Console.ReadLine();
                Console.Clear();
                goto start;
            }
            
            playerInfo();
            playYesNo1:
            Console.Write($"\n Are you ready to start fight? (Write: Yes/No) \n Your choice: ");
           
            startChoice = Console.ReadLine().ToLower();
            if (startChoice == "yes") ;
            else if (startChoice == "no")
            {
                Console.Write($" Sorry, see you next time, {nickname}");
                goto endGame;
            }
            else
            {
                Console.WriteLine(" Dont understand. Try again");
                goto playYesNo1;
            }

            Console.WriteLine(" Let`s go. Press Enter to contnite.");
            Console.ReadLine();

            string playerChoice;
            string[] compChoice = {"rock", "paper", "scissors"};
            Random rand = new Random();
            reloadedGame:
            int winRound = 0;
            int loseRound = 0;

            for (int i = 0; i < 3; i++)    
            {
                int compRandom = rand.Next(0, 3);
                Console.Write("\n Make your choice - Rock, Paper or Scissors.");
            incorrectInput:
                Console.Write("\n Your choice: ");
                playerChoice = Console.ReadLine().ToLower();
                if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissors") ;
                else
                {
                    Console.WriteLine(" Incorrect input. Try again.");
                    goto incorrectInput;
                }
                Console.WriteLine($" Computer choice: {compChoice[compRandom]}");

                string versus = playerChoice + "." + compChoice[compRandom];
                switch (versus)
                {
                    case "rock.rock":
                        Console.WriteLine(" Draw");
                        totalRounds++;
                        break;
                    case "rock.paper":
                        loseRound++;
                        totalRounds++;
                        Console.WriteLine(" Computer win this round");
                        break;
                    case "rock.scissors":
                        winRound++;
                        totalRounds++;
                        Console.WriteLine(" You win this round");
                        break;
                    case "paper.rock":
                        winRound++;
                        totalRounds++;
                        Console.WriteLine(" You win this round");
                        break;
                    case "paper.paper":
                        Console.WriteLine(" Draw");
                        totalRounds++;
                        break;
                    case "paper.scissors":
                        loseRound++; 
                        totalRounds++;
                        Console.WriteLine(" Computer win this round");
                        break;
                    case "scissors.rock":
                        loseRound++; 
                        totalRounds++;
                        Console.WriteLine(" You win this round");
                        break;
                    case "scissors.paper":
                        winRound++;
                        totalRounds++;
                        Console.WriteLine(" You win this round");
                        break;
                    case "scissors.scissors":
                        Console.WriteLine(" Draw");
                        totalRounds++;
                        break;

                }
                
            }
            Console.WriteLine(winRound > loseRound ? "\n You win this battle." : "\n You lose this battle.");
            if (winRound > loseRound) wins++;
            playYesNo2:
            Console.Write(" Are you wont to repit? (Write: Yes/No) \n Your choice: ");
            startChoice = Console.ReadLine().ToLower();
            if (startChoice == "yes") ;
            else if (startChoice == "no")
            {
                Console.Write($" Sorry, see you next time, {nickname}");
                goto endGame;
            }
            else
            {
                Console.WriteLine(" Dont understand. Try again");
                goto playYesNo2;
            }
            Console.WriteLine(" Press Enter to contnite.");
            Console.ReadLine();
            playerInfo();
            goto reloadedGame;

            endGame:
            Console.WriteLine("\n By by");


        }
    }
}
