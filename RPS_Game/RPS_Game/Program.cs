namespace RPS_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nickname;
            string startChoice;
            int age;
            int totalRounds = 0;
            int wins = 0;

            Console.Write("Write your nickname: ");
            nickname = Console.ReadLine();
            Console.Write("Write your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n Nickname: {nickname} \n Age: {age} \n Played rounds: {totalRounds} \n Wins: {wins}");
            Console.Write($"\n Are you ready to start fight? (Write: Yes/No) \n Your choice: ");

            startChoice = Console.ReadLine().ToLower();
            if( startChoice == "yes")
            {

            }
        }
    }
}
