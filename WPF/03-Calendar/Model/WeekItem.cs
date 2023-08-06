using System.Collections.ObjectModel;

namespace Calendar.Model
{
    public class WeekItem
    {
        public ObservableCollection<Day> DaysOfWeek { get; set; } = new ObservableCollection<Day>();

        public WeekItem(int day, int daysInMonth, int endOfPreviousMonth = 0)
        {
            int j = 0;

            if (endOfPreviousMonth != 0)
            {
                for (; day <= endOfPreviousMonth; j++, day++)
                {
                    DaysOfWeek.Add(new Day(day));
                }

                day = 1;
            }

            for (; j < 7; j++, day++)
            {
                DaysOfWeek.Add(new Day(day));

                if (day == daysInMonth)
                {
                    day = 0;
                }
            }
        }
    }
}