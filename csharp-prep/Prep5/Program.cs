using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome ();

        string fullname = PromptUserName ();
        int BestNumber = PromptUserNumber ();
        int squredNumber = SquareNumber (BestNumber);
        DisplayResult (fullname, squredNumber);




    }


    static void DisplayWelcome ()
    {
        Console.WriteLine ("Welcome to Joseph's Program!");
    }

    static string PromptUserName ()
    {
        Console.Write ("Please enter your name? ");
        string username = Console.ReadLine();

        return username;
    }


    static int PromptUserNumber ()
    {
        Console.Write ("Please enter your favorite number: ");
        string username1 = Console.ReadLine();
        int favoriteNumber = int.Parse (username1);

        return favoriteNumber;
    }


    static int SquareNumber (int TobeSquared)
    {
        int squre = TobeSquared * TobeSquared;
        return squre;
    }
    


    static void DisplayResult (string user, int squaredNum)
    {
        Console.WriteLine($"{user}, the square of your number is {squaredNum}");
    }

}