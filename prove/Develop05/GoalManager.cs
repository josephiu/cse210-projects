using System.ComponentModel.Design;

public class GoalManager
{
    private int _score = 0;
    // List <Goal> goalss = new List<Goal>();

    List <string> goalss = new List<string>();




    public GoalManager(int score)
    {        
        _score = score;
    }

    public void SetSore(int score)
    {
         _score = score;
    }
   
    public GoalManager()
    {

    }

    static void Start(string user)
    {

        Console.WriteLine("Menu Command Options:");
        Console.WriteLine("1. Create New Goal \n2. List Goal \n3. Save Goals \n 4. Load Goals \n5. Record Event \n6. Quit \nSelect a choice from the menu: ");
        


    }

    public void DisplayPlayerinfo()
    {
        Console.WriteLine($"You have {_score} points");

    }

    static void ListGoalNames()
    {
        Console.WriteLine("The Type of Goals Are:");
        Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Check List Goal \nWhich Type of Goal Would you want to Create? ");
        


    }

    public void ListGoalDetails()
    {
        Console.WriteLine($"The Goals Are:");

        int counter = 1; // this counter will help to track the index of any item in the list
        foreach (string item in goalss)
        {
            Console.WriteLine($"{counter}. {item}");
            counter += 1;
        }



    }

    public void CreatGoal()
    {

    }

    static void RecordEvent()
    {

    }

    static void SaveGoal()
    {

    }

    static void LoadGoials()
    {

    }



















}