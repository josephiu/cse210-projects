using System;

public class Resume 
{
    public string name;

// good practice to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");


        //  the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            job.DisplayMyJobDetails();
        }
    }
 

}








