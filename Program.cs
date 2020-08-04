using System;

namespace calendar
{
    class Program
    {
        static void Main(string[] args)
        {

            Calendar cal = new Calendar();


    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    
            cal.drawHeader();
            cal.drawDaysOfWeek();
            cal.drawDays();
        }
    }
}
