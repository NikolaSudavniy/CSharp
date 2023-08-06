using System.Collections.ObjectModel;
using System.Windows.Input;
using Tests.Model;
using Tests.View;

namespace Tests.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel() { }

        private int _correctAnswersCount;

        #region Binding Property
        private ObservableCollection<ITabItem> _items;

        public ObservableCollection<ITabItem> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new ObservableCollection<ITabItem>();
                    _correctAnswersCount = 0;

                    foreach (var item in new Questions().Themes[0])
                    {
                        _items.Add(item);
                    }

                    _items.Add(GetFinalPage());
                }
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        private int _selectedIndex = 0;

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged("SelectedIndex");
            }
        }
        #endregion

        #region ICommand
        private RelayCommand _continueCommand;

        public ICommand ContinueCommand
        {
            get
            {
                if (_continueCommand == null)
                {
                    _continueCommand = new RelayCommand(ExecuteContinueCommand, CanExecuteContinueCommand);
                }

                return _continueCommand;
            }
        }

        public void ExecuteContinueCommand(object parameter)
        {
            if ((Items[SelectedIndex] as Item).UnAnswered)
            {
                for (int i = 0; i < (Items[SelectedIndex] as Item).AnswersCorrectness.Count; i++)
                {
                    if ((Items[SelectedIndex] as Item).AnswersCorrectness[i] != (Items[SelectedIndex] as Item).AnswersSelectInfo[i])
                    {
                        break;
                    }

                    if (i == (Items[SelectedIndex] as Item).AnswersCorrectness.Count - 1)
                    {
                        _correctAnswersCount++;
                    }
                }

                (Items[SelectedIndex] as Item).UnAnswered = false;
            }

            Items[Items.Count - 1] = GetFinalPage();
            SelectedIndex++;
        }

        public bool CanExecuteContinueCommand(object parameter)
        {
            return SelectedIndex + 1 < Items.Count;
        }


        private RelayCommand _changeThemeCommand;

        public ICommand ChangeThemeCommand
        {
            get
            {
                if (_changeThemeCommand == null)
                {
                    _changeThemeCommand = new RelayCommand(ExecuteChangeThemeCommand);
                }

                return _changeThemeCommand;
            }
        }

        public void ExecuteChangeThemeCommand(object parameter)
        {
            Items = new ObservableCollection<ITabItem>();
            _correctAnswersCount = 0;

            foreach (var item in new Questions().Themes[int.Parse(parameter.ToString())])
            {
                Items.Add(item);
            }

            Items.Add(GetFinalPage());
        }
        #endregion

        public ITabItem GetFinalPage()
        {
            var finalItem = new FinalItem
            {
                Header = "Result",
                Control = new FinalPage(),
                Text = "Test is not finished"
            };

            for (int i = 0; i < Items.Count - 1; i++)
            {
                if ((Items[i] as Item).UnAnswered)
                {
                    return finalItem;
                }
            }

            finalItem.Text = $"Result: {_correctAnswersCount}/{_items.Count - 1}";

            for (int i = 0; i < Items.Count - 1; i++)
            {
                finalItem.Text += $"\n {Items[i].Header}: ";
                var answers = (Items[i] as Item).AnswersCorrectness;

                for (int j = 0; j < answers.Count; j++)
                {
                    if (answers[j])
                    {
                        finalItem.Text += $"{(Items[i] as Item).Answers[j]}; ";
                    }
                }
            }

            return finalItem;
        }
    }
}