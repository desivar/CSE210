using System;


class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new RunningActivity("25 April 2021",7.7,30));
        activities.Add(new CyclingActivity("2 September 2022",9.7,30));
        activities.Add(new Swimming("17 September 2024",88,30));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nACTIVITY N°{index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();    
    }
}