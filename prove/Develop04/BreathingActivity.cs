public class BreathingActivity : Activity
{
    public BreathingActivity (string ActivityName, string ActivityDetails) : base(ActivityName, ActivityDetails)
    {

    }

    public void Run()
    {
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner();

        Console.WriteLine();
        Console.WriteLine();

        

        Console.Write("Breath in..");
        ShowCountDown(4);
        Console.WriteLine();
        Console.Write("Breath out..");
        ShowCountDown(6);

        Console.WriteLine();
        Console.WriteLine();


        Console.Write("Breath in..");
        ShowCountDown(4);
        Console.WriteLine();
        Console.Write("Breath out..");
        ShowCountDown(6);

        Console.WriteLine();
        Console.WriteLine();

        
        Console.Write("Breath in..");
        ShowCountDown(4);
        Console.WriteLine();
        Console.Write("Breath out..");
        ShowCountDown(6);

        Console.WriteLine();
        Console.WriteLine();

        ShowSpinner();








    }



}