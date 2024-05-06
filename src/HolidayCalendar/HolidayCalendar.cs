using System;
using System.Collections.Generic;

namespace HolidayCalendar
{
    public class HolidayCalendar : IHolidayCalendar
    {
       public bool IsHoliday(DateTime date)
       {
      
            if (date.Year == 2024 && date.Month == 1 && date.Day == 1)
                return true;

            if (date.Year == 2024 && date.Month == 3 && date.Day == 28)
                return true;

            if (date.Year == 2024 && date.Month == 3 && date.Day == 29)
                return true;

            if (date.Year == 2024 && date.Month == 3 && (date.Day == 31 || date.Day == 1))
                return true;

            if (date.Year == 2024 && date.Month == 5 && date.Day == 9)
                return true;

            if (date.Year == 2024 && date.Month == 5 && (date.Day == 19 || date.Day == 20))
                return true;

            if (date.Year == 2024 && date.Month == 6 && date.Day == 5)
                return true;

            return false;
        }


        public ICollection<DateTime> GetHolidays(DateTime startDate, DateTime endDate)
        {
            // TODO: Implement holiday logic
            List<DateTime> holidays = new List<DateTime>();

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if (IsHoliday(currentDate))
                {
                    holidays.Add(currentDate);
                }
            }

            return holidays;
        }
    }
}
        