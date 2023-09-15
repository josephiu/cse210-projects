using System;

class Program
{
    static void Main(string[] args)
    {
         
        
        // Console.WriteLine("Welcome!");
        // Console.WriteLine("What is the magic number?" );
        // string user = Console.ReadLine();

        // int magic = int.Parse(user);

        // Console.WriteLine("What is your guess?" );
        // string user1 = Console.ReadLine();

        // int guess = int.Parse(user1);

          

        // //part 1 and 2

        
        // if (guess < magic)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else if (guess > magic)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else
        // {
        //     Console.WriteLine("you guessed it");
        // }
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    




       
    }
}