using System;

namespace interns_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            HolidayCalendar.HolidayCalendar calendar = new HolidayCalendar.HolidayCalendar();
            
            DateTime testDate = new DateTime(2024, 12, 25);
            bool isHoliday = calendar.IsHoliday(testDate); 
            
            Console.WriteLine($"Is {testDate.Date} a holiday? {isHoliday}");

            DateTime startDate = new DateTime(2024, 1, 1);
            DateTime endDate = new DateTime(2024, 12, 31);
            var holidays = calendar.GetHolidays(startDate, endDate);

            Console.WriteLine($"Holidays in 2024: ");
            foreach (var holiday in holidays)
            {
                Console.WriteLine(holiday);
            }
        }
    }
}
