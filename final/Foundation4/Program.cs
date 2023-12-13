using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new RunningActivity("24 Feb 2024",6.7,30));
        activities.Add(new CyclingActivity("18 Oct 2023",9.6,30));
        activities.Add(new Swimming("24 Dec 2023",96,30));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nACTIVITY N°{index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();    
    }
}