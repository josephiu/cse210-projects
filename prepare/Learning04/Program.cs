using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment _myAssignment = new Assignment("Samuel Bennett", "Multiplication");
       
        Console.WriteLine(_myAssignment.GetSummary());



        MathAssignment _myMaths = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(_myMaths.GetSummary());
        Console.WriteLine(_myMaths.GetHomeworkList());


        WritingAssignment _writingAssingment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(_writingAssingment.GetSummary());
        Console.WriteLine(_writingAssingment.GetWritingInformation());
    }
    
}