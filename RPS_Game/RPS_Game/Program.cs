using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel;

namespace RPS_Game
{
    internal class Program
    {
        static void Main(string[] args)
         {/*
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
            playYesNo:
            Console.Write($"\n Are you ready to start fight? (Write: Yes/No) \n Your choice: ");

            test:
           
            startChoice = Console.ReadLine().ToLower();
            if (startChoice == "yes") ;
            else if (startChoice == "no")
            {
                Console.Write($"Sorry, see you next time, {nickname}");
            //    goto endGame;
            }
            else
            {
                Console.WriteLine("Dont understand. Try again");
                goto playYesNo;
            }
           
                Console.WriteLine("lets play");
                Console.ReadLine();

            goto test;
            */
           
            string playerChoice;
            int round = 0;
            string[] compChoice = {"rock", "paper", "scissors"};
            Random rand = new Random();

            int winRound = 0;

            for (int i = 0; i < 10; i++)    
            {
                int compRandom = rand.Next(0, 3);
                Console.Write("\n Make your choice - Rock, Paper or Scissors.");
            incorrectInput:
                Console.Write("\n Your choice: ");
                playerChoice = Console.ReadLine().ToLower();
                if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissors") ;
                else
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    goto incorrectInput;
                }
                Console.WriteLine($" Computer choice: {compChoice[compRandom]}");

                string versus = playerChoice + "." + compChoice[compRandom];
                switch (versus)
                {
                    case "rock.rock":
                        Console.WriteLine(" Draw");
                        break;
                    case "rock.paper":
                        winRound -= 1;
                        Console.WriteLine(" Computer win this round");
                        break;
                    case "rock.scissors":
                        winRound += 1;
                        Console.WriteLine(" You win this round");
                        break;
                    case "paper.rock":
                        winRound += 1;
                        Console.WriteLine(" You win this round");
                        break;
                    case "paper.paper":
                        Console.WriteLine(" Draw");
                        break;
                    case "paper.scissors":
                        winRound -= 1;
                        Console.WriteLine(" Computer win this round");
                        break;
                    case "scissors.rock":
                        winRound += 1;
                        Console.WriteLine(" You win this round");
                        break;
                    case "scissors.paper":
                        winRound += 1;
                        Console.WriteLine(" You win this round");
                        break;
                    case "scissors.scissors":
                        Console.WriteLine(" Draw");
                        break;






                }
                /*
                if (playerChoice == "rock")
                {
                    if (playerChoice == "rock") Console.WriteLine("Draw");
                    else if (playerChoice == "paper")
                    {
                        winRound -= 1;
                        Console.WriteLine("Computer win this round");
                    }
                    else if (playerChoice == "scissors")
                    { 
                        winRound += 1;
                        Console.WriteLine("You win this round");
                    } 
                }
                if (playerChoice == "paper")
                {
                    if (playerChoice == "rock")
                    {
                        winRound += 1;
                        Console.WriteLine("You win this round");
                    }
                    else if (playerChoice == "paper") Console.WriteLine("Draw");
                    else if (playerChoice == "scissors")
                    { 
                        winRound -= 1;
                        Console.WriteLine("Computer win this round");
                    } 
                }
                if (playerChoice == "scissors")
                {
                    if (playerChoice == "rock")
                    { 
                        winRound -= 1;
                        Console.WriteLine("Computer win this round");
                    } 
                    else if (playerChoice == "paper")
                    { 
                        winRound += 1;
                        Console.WriteLine("You win this round");
                    } 
                    else if (playerChoice == "scissors") Console.WriteLine("Draw");
                }*/
            }
            


        }
    }
}
