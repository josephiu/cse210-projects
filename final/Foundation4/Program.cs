using System;

class Program
{
    static void Main(string[] args)
    {
      List<Activity> activities = new List<Activity>();

        Running running = new Running("13 Oct 2023", 1660, 8.0);
        Cycling cycling = new Cycling("17 Oct 2023", 2000, 6.0);
        Swimming swimming = new Swimming("08 Oct 2023", 6200, 50);

        // Adding the different activities into the Activity list

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        //This iterates through all the different activities added in the list 

        foreach (Activity activity in activities)
        {
        //This print out each of the different activites 

            Console.WriteLine(activity.GetSummary());
        }
    }
    
}