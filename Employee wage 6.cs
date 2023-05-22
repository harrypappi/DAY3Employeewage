using System;

public class Program
{
    public static void Main(string[] args)
    {
        const int MaxWorkingHours = 100;
        const int MaxWorkingDays = 20;
        const double HourlyRate = 10.0;

        int totalWorkingHours = 0;
        int totalWorkingDays = 0;
        double totalWages = 0.0;

        while (totalWorkingHours < MaxWorkingHours && totalWorkingDays < MaxWorkingDays)
        {
            totalWorkingHours += 8;
            totalWorkingDays++;
            totalWages += (8 * HourlyRate);
        }

        Console.WriteLine("Total working hours: " + totalWorkingHours);
        Console.WriteLine("Total working days: " + totalWorkingDays);
        Console.WriteLine("Total wages: $" + totalWages);
    }
}
