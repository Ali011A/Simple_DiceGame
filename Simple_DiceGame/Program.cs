namespace Simple_DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Simple_DiceGame");
            Console.WriteLine("Press any key to start the game");
             Console.ReadKey();
            int randomNumber = 0;
            int enemyRandomNumber = 0;
            int playerscore = 0;
            int enemyScore = 0;
            for (int i = 0; i < 10; i++)
            {
              Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();
                randomNumber = new Random().Next(1, 7);
                Console.WriteLine($"You rolled a {randomNumber}");
                Console.WriteLine("......");
                System.Threading.Thread.Sleep(1000);
                enemyRandomNumber = new Random().Next(1, 7);
                Console.WriteLine($"The enemy rolled a {enemyRandomNumber}");
                Console.WriteLine("......");
                System.Threading.Thread.Sleep(1000);
                if (randomNumber > enemyRandomNumber)
                {
                    Console.WriteLine("You win this round");
                    playerscore++;
                }
                else if (randomNumber < enemyRandomNumber)
                {
                    Console.WriteLine("You lose this round");
                    enemyScore++;
                }
                else
                {
                    Console.WriteLine("It's a draw");
                }
                Console.WriteLine($"Your score is {playerscore}");
                Console.WriteLine($"The enemy score is {enemyScore}");
                Console.WriteLine("Press any key to exit the game :) good luck");
                if (playerscore > enemyScore)
                {
                    Console.WriteLine("You won the game bro");
                }
                else if (playerscore < enemyScore)
                {
                    Console.WriteLine("You lost the game bad luck");
                }
                else
                {
                    Console.WriteLine("It's a draw");
                }
                Console.ReadKey();
              
            }
            Console.ReadLine();
        }

    }
}
