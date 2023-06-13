using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_07_Date
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        private void DataTimeForm_Load(object sender, EventArgs e)
        {
            dayOfWeekLabel.Text = GetDayOfWeekRU(dateTimePicker.Value.DayOfWeek);
        }

        private void label1_Click(object sender, EventArgs e){}

        private string GetDayOfWeekRU(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "Понедельник";
                case DayOfWeek.Tuesday:
                    return "Вторник";
                case DayOfWeek.Wednesday:
                    return "Среда";
                case DayOfWeek.Thursday:
                    return "Четверг";
                case DayOfWeek.Friday:
                    return "Пятница";
                case DayOfWeek.Saturday:
                    return "Суббота";
                case DayOfWeek.Sunday:
                    return "Воскресенье";
            }

            return string.Empty;
        }

        private TimeSpan GetTimeSpanToNow(DateTime dateTimeFrom)
        {
            if (DateTime.Now > dateTimeFrom)
                return DateTime.Now - dateTimeFrom;
            else if (DateTime.Now == dateTimeFrom)
                return default(TimeSpan);
            else
                return dateTimeFrom - DateTime.Now;
        }

        private void enteredDataLabel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void timeSpanGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void timeSpanLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dayOfWeekLabel.Text = GetDayOfWeekRU(dateTimePicker.Value.DayOfWeek);
        }

        private void inYearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            timeSpanLabel.Text = ((long)(GetTimeSpanToNow(dateTimePicker.Value).TotalDays / 365 / 30.5)).ToString();
        }

        private void inMonthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            timeSpanLabel.Text = ((long)(GetTimeSpanToNow(dateTimePicker.Value).TotalDays / 30.5)).ToString();
        }

        private void inDaysRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            timeSpanLabel.Text = ((long)GetTimeSpanToNow(dateTimePicker.Value).TotalDays).ToString();
        }

        private void inMinutesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            timeSpanLabel.Text = ((long)GetTimeSpanToNow(dateTimePicker.Value).TotalMinutes).ToString();
        }

        private void inSecondRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            timeSpanLabel.Text = ((long)GetTimeSpanToNow(dateTimePicker.Value).TotalSeconds).ToString();
        }
    }
}
