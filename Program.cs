using System;

namespace interns_challenge
{
    class Program
    {
        static void Main(string[] args)
        { 
            // implement 
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
/*
here is what i got after run code 
Is 12/25/2024 12:00:00 AM a holiday? False
Holidays in 2024:    
1/1/2024 12:00:00 AM 
3/28/2024 12:00:00 AM
3/29/2024 12:00:00 AM
3/31/2024 12:00:00 AM
5/9/2024 12:00:00 AM
5/19/2024 12:00:00 AM
5/20/2024 12:00:00 AM
6/5/2024 12:00:00 AM
*/