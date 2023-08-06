using System;
using Calendar.Model;
using System.Windows;
using System.Windows.Input;
using static System.Globalization.CultureInfo;

namespace Calendar.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private int _selectedMonth;
        private readonly int _year = DateTime.Today.Year;

        public MainViewModel()
        {
            _selectedMonth = DateTime.Now.Month;
            Month = new MonthItem(_year, _selectedMonth);
            MonthName = CurrentCulture.DateTimeFormat.GetMonthName(_selectedMonth);
        }

        #region Binding ListView
        private MonthItem _month;
        public MonthItem Month
        {
            get => _month;
            set
            {
                _month = value;
                OnPropertyChanged(nameof(Month));
            }
        }

        private string _monthName;
        public string MonthName
        {
            get => _monthName;
            set
            {
                _monthName = value;
                OnPropertyChanged(nameof(MonthName));
            }
        }
        #endregion

        #region ICommand
        private RelayCommand _monthChanged;

        public ICommand MonthChanged
        {
            get
            {
                if (_monthChanged == null)
                    _monthChanged = new RelayCommand(ExecuteMonthChanging);
                return _monthChanged;
            }
        }

        public void ExecuteMonthChanging(object parameter)
        {
            if (Enum.TryParse(parameter.ToString(), out Month month))
            {
                if (_selectedMonth != (int)month)
                {
                    _selectedMonth = (int)month;
                    MonthName = CurrentCulture.DateTimeFormat.GetMonthName(_selectedMonth);
                    Month = new MonthItem(_year, _selectedMonth);
                }
            }
        }

        private RelayCommand _selectDay;

        public ICommand SelectDay
        {
            get
            {
                if (_selectDay == null)
                    _selectDay = new RelayCommand(ExecuteSelectDay);
                return _selectDay;
            }
        }

        public void ExecuteSelectDay(object parameter)
        {
            MessageBox.Show(parameter.ToString());
        }
        #endregion
    }
}