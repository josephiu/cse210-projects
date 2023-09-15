using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");

        Console.WriteLine("What is your grade Percentage? ");
        string user = Console.ReadLine();
        int grade = int.Parse(user);

        string letter = "";





        if (grade >= 90 )
        {   
            if (grade > 93 )
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }

        } 
        else if (grade >= 80)
        {
            if (grade > 83 )
            {
                letter = "B-";
            }
            else if (grade >= 87 )
            {
                letter = "B+";
            }
            else
            {
                letter = "B";  
            }     
        }
        else if (grade >= 70 )
        {
            if (grade < 73 )
            {
                letter = "C-";
            }
            else if (grade >= 77 )
            {
                letter = "C+";
            }
            else
            {
                letter = "C";
            }
        }
        else if (grade >= 60 )
            
        {
            if (grade < 63)
            {
                letter = "D-";
            }
            else if (grade >= 67 )
            {
                letter = "D+";
            }
            else
            {
                letter = "D";
            }

        }
        else if (grade < 60 )
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is: {letter}");



        if (grade >= 70)
        {
            Console.WriteLine("Congratulations You Passed the Course");
        }
        if (grade < 70)
        {
            Console.WriteLine("Please Put More Effort Next time");  
        }


        
    }
}