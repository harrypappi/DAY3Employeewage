using System;

public class Program
{
    public static void Main(string[] args)
    {
        const int WorkingDaysPerMonth = 20;
        const double DailyWage = 100.0;

        double monthlyWage = WorkingDaysPerMonth * DailyWage;

        Console.WriteLine("Wages for a month (assuming 20 working days): $" + monthlyWage);
    }
}
