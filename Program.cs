using System;

namespace calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar cal;



            if (args.Length == 0)
            {
                cal = new Calendar();
                cal.drawCalendar();

            }
            else if (args.Length == 1)
            {
                cal = new Calendar(getArg(args[0]));
                cal.drawCalendar();
            }
            else if (args.Length == 2)
            {
                cal = new Calendar(getArg(args[0]),
                 getArg(args[1]));
                cal.drawCalendar();
            }
            else
            {
                Console.WriteLine("Enter valid count of command-line arguments!");
                System.Environment.Exit(1);
            }
        }

        private static int getArg(String consoleArg)
        {
            int num;
            bool test = int.TryParse(consoleArg, out num);
            if (!test)
            {
                Console.WriteLine("Please enter a valid argument");
                System.Environment.Exit(1);
            }
            return num;
        }

    }
}
