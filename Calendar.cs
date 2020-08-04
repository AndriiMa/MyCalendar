using System;

namespace calendar
{

    public class Calendar
    {

        private DateTime dateNow { get; }
        private const String wordDelimiter = "\t";

        public Calendar()
        {
            this.dateNow = DateTime.Now;
        }

        public Calendar(int month)
        {
            this.dateNow = new DateTime(DateTime.Now.Year, month, 1);
        }

        public Calendar(int month, int year)
        {
            this.dateNow = new DateTime(year, month, 1);
        }

        public void drawCalendar()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            drawHeader();
            drawDaysOfWeek();
            drawDays();
        }

        private void drawDaysOfWeek()
        {
            Console.WriteLine("Su\tMo\tTu\tWe\tTh\tFr\tSa\t");
        }

        private void drawHeader()
        {
            Console.WriteLine(dateNow.ToString("MMMM") + wordDelimiter + dateNow.ToString("yyyy"));
        }

        private void drawDays()
        {
            DateTime firsDateOfMonth = new DateTime(dateNow.Year, dateNow.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(dateNow.Year, dateNow.Month);
            DateTime lastDateInMonth = new DateTime(dateNow.Year, dateNow.Month, daysInMonth);

            int tabs = Convert.ToInt32(firsDateOfMonth.DayOfWeek);

            Console.WriteLine();
            addTabs(tabs);

            int counter = tabs;
            for (var dt = firsDateOfMonth; dt <= lastDateInMonth; dt.AddDays(1))
            {

                changeColour(dt);
                Console.Write(dt.Day + wordDelimiter);
                dt = dt.AddDays(1);
                if (counter == 6)
                {
                    Console.WriteLine();
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

        }

        private void changeColour(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Sunday ||
                dt.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (dt == dateNow)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void addTabs(int tabs)
        {
            String result = "";

            for (int i = 0; i < tabs; i++)
            {
                result += wordDelimiter;
            }
            Console.Write(result);
        }
    }

}