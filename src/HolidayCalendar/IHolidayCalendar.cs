using System;
using System.Collections.Generic;

namespace HolidayCalendar
{
    public interface IHolidayCalendar
    {
        bool IsHoliday(DateTime date);
        ICollection<DateTime> GetHolidays(DateTime startDate, DateTime endDate);
    }
}