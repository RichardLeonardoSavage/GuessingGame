namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount == 1)
                {
                    Console.WriteLine("Wrong! Here's a clue: This animal is from Africa");
                }
                if (guessCount == 2)
                {
                    Console.WriteLine(" Wrong again! Want another clue? this animal has 4 legs");
                }
                if (guessCount == 3)
                {
                    Console.WriteLine("This is your last chance! This animal has a reaaaalllly long neck!");
                }
                if (guessCount < guessLimit)
                {
                    Console.Write("Try to guess this animal: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }



                
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("You Win! This took you " + guessCount + " attempts.");
            }
            
            Console.ReadLine();

        }
    }
}