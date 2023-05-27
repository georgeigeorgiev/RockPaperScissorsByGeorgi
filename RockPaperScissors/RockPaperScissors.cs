namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string rock = "rock";
            const string paper = "paper";
            const string scissors = "scissors";

            Start:
            Console.Write($"Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }

            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }

            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }

            else
            {
                Console.WriteLine("Invalid input. Try Again...");
                goto Start;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);

            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = rock;
                    break;
                case 2:
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = scissors;
                    break;

            }

            Console.WriteLine($"The computer chose {computerMove}.");

            if (playerMove == rock && computerMove == rock || playerMove == scissors && computerMove == scissors || playerMove == paper && computerMove == paper)
            {
                Console.WriteLine("This game was a draw.");
            }

            else if (playerMove == rock && computerMove == scissors || playerMove == scissors && computerMove == paper || playerMove == paper && computerMove == rock)
            {
                Console.WriteLine("You win.");
            }

            else
            {
                Console.WriteLine("You lose.");
            }
        }
    }
}