using System;
using System.Collections.ObjectModel;

namespace Calendar.Model
{
    public class MonthItem
    {
        public int Year { get; set; }
        public int Month { get; set; }

        public ObservableCollection<WeekItem> Weeks { get; set; } = new ObservableCollection<WeekItem>();

        public MonthItem(int year, int month)
        {
            Year = year;
            Month = month;

            DateTime firtsDayOfMonth = new DateTime(Year, Month, 1);
            DateTime lastDayOfPreviousMonth = firtsDayOfMonth.AddDays(-1);
            int startOfWeek = 1;
            int dayInMonth = DateTime.DaysInMonth(Year, Month);

            if (lastDayOfPreviousMonth.DayOfWeek != DayOfWeek.Sunday)
            {
                Weeks.Add(
                    new WeekItem(
                        lastDayOfPreviousMonth.Day - (int)lastDayOfPreviousMonth.DayOfWeek + 1,
                        dayInMonth,
                        lastDayOfPreviousMonth.Day));

                startOfWeek = 7 - (int)lastDayOfPreviousMonth.DayOfWeek + 1;
            }

            for (; startOfWeek < dayInMonth; startOfWeek += 7)
            {
                Weeks.Add(new WeekItem(startOfWeek, dayInMonth));
            }
        }
    }
}