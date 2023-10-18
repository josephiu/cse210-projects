using System;

class Program
{
    static void Main(string[] args)
    {
     GoalManager goalManager = new GoalManager();

        int user = 1;
        while(user != 6)
        {
            //Console.Clear();
            goalManager.DisplayScore();
            Console.WriteLine("Welcome to Joseph's Mideful App.:");// i exeeded requirement by adding a greetings line to make the gamification interactive
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");

            int user2 = Convert.ToInt32(Console.ReadLine()); //use to convert string to integer or - Int32.Parse  

            if (user2 == 1)
            {
                //Create New Goal
                Console.Clear();
                goalManager.CreatedGoal();
            }     

            if (user2 == 2)

            {
                //List Goals
                Console.Clear();
                goalManager.ListGoalDetails();

            }

            if (user2 == 3)
            {
                //Save Goals
                Console.Clear();
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                goalManager.SaveGoals(fileName);

            }

            if (user2 == 4)
            {
                //Load Goals
                Console.Clear();
                Console.WriteLine("What is the name of the file you are loading?");
                string fileName = Console.ReadLine();
                goalManager.LoadGoals(fileName);

            }



            else

            {
                //Record Event
                Console.Clear();
                goalManager.RecordEvent();

            }

        }        
    }

  



}