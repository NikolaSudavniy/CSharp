using System.Collections.Generic;
using System.Windows.Controls;

namespace Tests.ViewModel
{
    public interface ITabItem
    {
        string Header { get; set; }
        UserControl Control { get; set; }
    }

    public class Item : ITabItem
    {
        public string Header { get; set; }
        public UserControl Control { get; set; }
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public List<bool> AnswersCorrectness { get; set; }
        public bool UnAnswered { get; set; } = true;
        public List<bool> AnswersSelectInfo { get; set; } = new List<bool> { false, false, false, false };
    }

    public class FinalItem : ITabItem
    {
        public string Header { get; set; }
        public UserControl Control { get; set; }
        public string Text { get; set; }
    }
}