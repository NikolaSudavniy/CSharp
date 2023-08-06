namespace Calendar.Model
{
    public class Day
    {
        public int DayNumber { get; set; }
        public Celebration Celebration { get; set; }

        public Day(int number)
        {
            DayNumber = number;
        }
    }
}