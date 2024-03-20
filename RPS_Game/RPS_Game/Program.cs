using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;

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
            string[] compChoice = {"rock", "paper", "scissors"};
            Random rand = new Random();
            int compRandom = rand.Next(0, 3);
            Console.Write(" Make your choice - Rock, Paper or Scissors.");
            incorrectInput:
            Console.Write("\n Your choice: ");
            playerChoice = Console.ReadLine().ToLower();
            Console.WriteLine(playerChoice);
            if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissors");
            else
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto incorrectInput;

            }
            Console.WriteLine($"Computer choice: {compChoice[compRandom]}");   
            
        }
    }
}
