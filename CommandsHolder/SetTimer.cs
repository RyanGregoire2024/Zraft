public class Timer
{
    public static int TIME_INTERVAL = 1;
    public static Thread myThread;

    public static void SetTimer()
    {

        Console.WriteLine("Please Enter Time Interval to Set? ");
        TIME_INTERVAL = int.Parse(Console.ReadLine());

        while (true)
        {
            
            GetTimer();

            Console.WriteLine("Break is Done");
            Console.ReadLine();
            
        }
    }
    
    public static void GetTimer()
    {
        Thread.Sleep(TIME_INTERVAL * 60 * 1000);
        Console.WriteLine("Minutes: " + TIME_INTERVAL);
        Console.ReadLine();

    }
    
    public static void BreakTimer()
    {
        Thread.Sleep(5 * 60 * 1000);
        Console.WriteLine("You Have: " + TIME_INTERVAL + " Minutes Left for Break");
        Console.ReadLine();

    }
    
}