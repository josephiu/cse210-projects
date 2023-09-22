using System;

class Program
{
    static void Main(string[] args)
    {

       
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Analist";
        job1._startYear = 2014;
        job1._endYear = 2018;

        job1.DisplayMyJobDetails();
        
       


        Job job2 = new Job();
        job2._company = "Apple";
        job2._startYear = 2018;
        job2._jobTitle = "Software Developer";
        job2._endYear = 2022;

        job2.DisplayMyJobDetails();

        Resume myResume =  new Resume();
        myResume.name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        


    }
}