using System;
namespace NumberGuess

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(1,99);
            // For debug:
            // Console.WriteLine(randomNum);
            int lives = 5;
            while (lives > 0)
            {
                Console.WriteLine("Guess the number between 1 and 99! You have {0} guesses remaining!", lives);
                String input = Console.ReadLine();
                int numinput = Int32.Parse(input);
                if(numinput > randomNum)
                {
                    Console.WriteLine("Your guess is above the number!");
                    lives--;
                }
                if (numinput == randomNum)
                {
                    Console.WriteLine("You guessed correctly!");
                    // Below line is so program does not break before user can read output. 
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Your guess is below the number!");
                    lives--;
                }
                
            }
        }
    }
}
