using System;

class Program
{
    static void Main(string[] args)
    {
        BicycleActivity bicycleActivity = new BicycleActivity("Bicycle","05/26/2004",30,20);
        RunningActivity runningActivity = new RunningActivity("Running","05/26/2004",30,10);
        SwimmingActivity swimmingActivity = new SwimmingActivity("Swimming","05/26/2004",30,50);
        
        List<Activity> activities = new List<Activity>() {bicycleActivity, runningActivity, swimmingActivity};
        
        foreach (Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}