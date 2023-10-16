using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Joseph's Tracker ");

         List<string> myvalue = new List<string>{"emeka", "chinedu", "master", "tazes"};

        int counter = 1;
        foreach (string item in myvalue)
        {
            Console.WriteLine($"indesx {counter} - {item}");
            counter += 1;
        }















    }








    
   



}