using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {


      

        string subject = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.";
        //int size = 2;
        Reference myrefer = new Reference("Proverbs", "3", "5");
        Scripture script = new Scripture(subject, myrefer);



        string user = "";
        while (user != "quit")
        {
            Console.WriteLine("Welcome to Joseph Scrip Memorizer App");// i exceeded requirement by adding welcome note to the user
            Console.WriteLine();

            
            Console.Clear();

            script.DisplayWords();

            Console.WriteLine("\nPress enter to continue or type quit to exit");


            if (script.IsCompletelyHidden())
            {
                break;
            }
            user = Console.ReadLine();


            if (user == "quit")
                break;

            script.HideRandomWords();
        }
    }
}