

public class PromptGenerators
{
    public List<string> promter = new List<string>{"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"};


    public PromptGenerators()
{

}

    public string GetRandomPromt()

    {
        //Help from stack overflow
        Random randomGenerator = new Random();
        int prompting = randomGenerator.Next(promter.Count);
        string promted = promter[prompting];

        return promted;
    }




}
