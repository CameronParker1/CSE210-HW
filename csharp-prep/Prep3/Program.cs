using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Console.WriteLine("What is the magic number? ");
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); 

        //Console.WriteLine("What is your guess? ");
        //string guess = Console.ReadLine();
        //int userGuess = int.Parse(guess);

        int userGuess = -1;
        
        while (userGuess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            
            if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }

            else if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}