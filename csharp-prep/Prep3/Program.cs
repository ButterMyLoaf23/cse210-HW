using System;

class Program
{
    static void Main()
    {
        Random randomNumGenerator = new Random();
        int magicNum = randomNumGenerator.Next(1,100);
        
        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("Guess a number 1-100: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the number");
            }
        }
    }
}