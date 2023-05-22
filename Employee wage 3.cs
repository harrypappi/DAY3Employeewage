using System;

class Program
{
    static void Main()
    {
        int wagePerHour = 20;
        int fullDayHours = 8;
        int partTimeHours = 8;

        int fullTimeWage = wagePerHour * fullDayHours;
        int partTimeWage = wagePerHour * partTimeHours;

        Console.WriteLine("Full-time Employee Daily Wage: $" + fullTimeWage);
        Console.WriteLine("Part-time Employee Daily Wage: $" + partTimeWage);
    }
}
