public class ListingActivity : Activity
{
    private int _count;

    private List<string>_mypromptlist = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"

    };
    
    private List<string>_mylisting = new List<string>();

     public ListingActivity(string activityName, string ActivityDetails) : base(activityName, ActivityDetails)
     {
     
     }

     public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner();
    }


public string GetRandomPromptFromList()

    {
       
        Random randomGenerator = new Random();
        int prompting = randomGenerator.Next(_mypromptlist.Count);
        string promted = _mypromptlist[prompting];

        return promted;
    }






public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        string myprompt = GetRandomPromptFromList();
        Console.WriteLine($"---{myprompt}---");
        Console.WriteLine("You may beging in:");
            
    }


 public void GetListFromUser(string user)
 {
    _mylisting.Add(user);
 }

    
}