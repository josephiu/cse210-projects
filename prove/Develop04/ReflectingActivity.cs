public class ReflectingActivity : Activity
{
    private List <string> _prompts = new List<string>{
        "hink of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};


    private List <string> _question  = new List<string>{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};



    public ReflectingActivity(string ActivityName, string ActivityDetails) : base(ActivityName, ActivityDetails)
    {


    }


    public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner();
    }

    


    public string GetRandomPrompt()

    {
       
        Random randomGenerator = new Random();
        int prompting = randomGenerator.Next(_prompts.Count);
        string promted = _prompts[prompting];

        return promted;
    }

    public string GetRandomQuestion()

    {       
        Random randomGenerator = new Random();
        int prompting = randomGenerator.Next(_question.Count);
        string questionPromt = _question[prompting];

        return questionPromt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(); // to make line spacing

        string myprompt = GetRandomPrompt();
        Console.WriteLine($"---{myprompt}---");

        Console.WriteLine(); // to make line spacing

        Console.WriteLine("When you have something in mind press enter to continue.");       


    }

//in the program class there will be a countdown and a cleared console before this question

    public void DisplayQuestions()
    {
        string myQuestion = GetRandomQuestion();
        Console.Write($"> {myQuestion} ");
    }



}





// public List<string> promter = new List<string>{"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?",
//     "If I had one thing I could do over today, what would it be?"};


//     public PromptGenerators()
// {

// }

//     public string GetRandomPromt()

//     {
//         //Help from stack overflow
//         Random randomGenerator = new Random();
//         int prompting = randomGenerator.Next(promter.Count);
//         string promted = promter[prompting];

//         return promted;
//     }
