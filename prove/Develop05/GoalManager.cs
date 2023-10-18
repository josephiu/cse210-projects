using System.ComponentModel.Design;

public class GoalManager
{
    private int _score = 0;

    // an empty list which will be populated with different goals
    List <Goal> _goals = new List<Goal>();   

  
    public void SetSore(int score)
    {
         _score += score;
    }

      public int GetScore()
    {        
        return _score ;
    }

// this is going to set thew goals into our _goals list 
    public void SetList(Goal goals)
    {
        _goals.Add(goals);
    }

// this is going to retturn what is in the list 
   public List<Goal> GetList()
   {
     return _goals;
   }
    public void ListGoalDetails()
    {
        Console.WriteLine("Yor Goals are:");
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}");
        }
    }

    public void CreatedGoal()
    {
        Console.WriteLine("The types of Goals are");
        Console.WriteLine(" 1. Simple Goal\n 2.Eternal Goal\n 3.Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        //this code below converts user imputs to integers

        int user = Convert.ToInt32(Console.ReadLine());

        if (user == 1)
        {
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            SetList(simpleGoal);            

        }

        if (user == 2)
        {
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            SetList(eternalGoal);

        }

        if (user == 3)
        {
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("What is the bonus for completing your goal? ");
            int bonus = int.Parse(Console.ReadLine());
            Console.Write("How many in the series to complete your goal? ");
            int target = int.Parse(Console.ReadLine());

            CheckListGoal checkListGoal = new CheckListGoal(name, description, points, bonus, target);
            SetList(checkListGoal);
        }



    }     
    
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetName()}");
        }
        Console.Write("Which goal did you accomplish: ");
        int user = int.Parse(Console.ReadLine()) -1;        
        if (ResetGoal(user) == false)
        {
            _goals[user].RecordEvent();
            SetSore(int.Parse(_goals[user].Getpoints()));
        }
    }
    public void SaveGoals(string file)
    {
        Console.WriteLine("What is the name of the file?");
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(GetScore());
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    } 
   
    public void LoadGoals(string file)
    {
        _goals.Clear();
        string filename = file;
        string[] lines = File.ReadAllLines(filename);
        //load score
        _score = int.Parse(lines[0]);
        
        //load goals
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(",");
            switch(parts[0])
            {
                case "SimpleGoal":
                {
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                    simpleGoal.SetComplete(bool.Parse(parts[4]));
                    _goals.Add(simpleGoal);
                    break;
                }
                case "EternalGoal":
                {
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                    _goals.Add(eternalGoal);
                    break;
                }
                case "CheckListGoal":
                {
                    CheckListGoal checkListGoal = new CheckListGoal(parts[1], parts[2], parts[3], int.Parse(parts[6]), int.Parse(parts[5]));
                    checkListGoal.SetAmountCompleted(int.Parse(parts[4]));
                    _goals.Add(checkListGoal);
                    break;
                }
            }
        }              
    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have {GetScore()} points.\n");
    }
    public bool ResetGoal(int selection)
    {
        bool change = false;
        if (_goals[selection].IsComplete())
        {            
            Console.WriteLine("\nThis goal has already been completed. Would you like to reset it?");
            Console.Write("Type 'y' for yes or 'n' for no: ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                _goals[selection].SetComplete(false);
                Console.WriteLine("Good thinking, you're goal has been reset");
                ListGoalDetails();
                change = true;
            }
            else
            {
                RecordEvent();
                change = false;
            }
        }
        return change;
    }
}