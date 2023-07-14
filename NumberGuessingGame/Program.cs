namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int winNum = randomNumber.Next(0, 100);
            bool win = false;

            do
            {
                Console.Write("Guess a number between 0 and 100:  ");
                string guess = Console.ReadLine();

                int intGuess = int.Parse(guess);

                if (intGuess > winNum)
                {
                    Console.WriteLine("To high! Guess lower...");
                }
                else if (intGuess < winNum)
                {
                    Console.WriteLine("To low! Guess higher...");
                }
                else if (intGuess == winNum)
                {
                    Console.WriteLine("You Win!!!");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}