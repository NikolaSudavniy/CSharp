using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileEditor
{
    public class TextFileEditorPresenter
    {
        private TextFileEditorForm _view;
        private TextFileEditorModel _model;

        public TextFileEditorPresenter(TextFileEditorForm view, TextFileEditorModel model)
        {
            _view = view;
            _model = model;
            _view.ClickOnButton += (sender, e) => { DoEvent(e.ButtonName); };
            _view.FormCaption = "New document";
            _model.NewDoc();
        }

        private void DoEvent(ButtonName button)
        {
            switch (button)
            {
                case ButtonName.Open:
                    OpenFile();
                    break;
                case ButtonName.New:
                    NewFile();
                    break;
                case ButtonName.Save:
                    Save();
                    break;
                case ButtonName.SaveAs:
                    SaveAs();
                    break;
                case ButtonName.Exit:
                    if (_view.TextFromBox.Length != 0 || _view.TextFromBox.Length == 0 && !_model.IsNew)
                        if (_view.OkCancelMessageBox("Current text will be removed. \nContinue?", "Wait!"))
                            Environment.Exit(1);
                    break;
                case ButtonName.Copy:
                    Copy();
                    break;
                case ButtonName.Cut:
                    Cut();
                    break;
                case ButtonName.Paste:
                    Paste();
                    break;
                case ButtonName.Cancel:
                    Cancel();
                    break;
            }
        }

        private void OpenFile()
        {
            if (_view.TextFromBox.Length != 0)
                if (!_view.OkCancelMessageBox("Current text will be removed. \nContinue?", "Wait!"))
                    return;

            var fileName = _view.OpenFileDialog();
            if (fileName != null)
            {
                try
                {
                    if (_model.OpenFile(fileName, out string text))
                    {
                        _view.FormCaption = fileName;
                        _view.TextFromBox = text;
                    }
                }
                catch
                {
                    _view.InfoMessageBox("Wrong file saving. Try again", "Wrong!");
                }
            }
        }

        private void NewFile()
        {
            if (_view.TextFromBox.Length != 0 || _view.TextFromBox.Length == 0 && !_model.IsNew)
                if (!_view.OkCancelMessageBox("Current text will be removed. \nContinue?", "Wait!"))
                    return;

            _view.ClearText();
            _model.NewDoc();
            _view.FormCaption = "New document";
        }

        private void Save()
        {
            try
            {
                if (_model.IsNew)
                {
                    SaveAs();
                }
                else
                {
                    if (_model.Save(_view.TextFromBox))
                        _view.InfoMessageBox("Saved successfully", "Done");
                }
            }
            catch
            {
                _view.InfoMessageBox("Wrong file saving. Try again", "Wrong!");
            }
        }

        private void SaveAs()
        {
            var fileName = _view.SaveFileDialog();

            if (fileName != null)
            {
                try
                {
                    if (_model.Save(_view.TextFromBox, fileName))
                    {
                        _view.InfoMessageBox("Saved successfully", "Done");
                        _view.FormCaption = _model.FileName;
                    }
                }
                catch
                {
                    _view.InfoMessageBox("Wrong file saving. Try again", "Wrong!");
                }
            }
        }

        private void Copy()
        {
            if (_view.SelectedText.Length != 0)
            {
                _model.Buffer = _view.SelectedText;
                _model.PrevStateText = _view.TextFromBox;
                _view.CopyText();
            }
        }

        private void Cut()
        {
            if (_view.SelectedText.Length != 0)
            {
                _model.Buffer = _view.SelectedText;
                _model.PrevStateText = _view.TextFromBox;
                _view.CutText();
            }
        }

        private void Paste()
        {
            if (_model.Buffer != null)
            {
                _model.PrevStateText = _view.TextFromBox;
                _view.PasteText(_model.Buffer);
            }
        }

        private void Cancel()
        {
            if (_model.PrevStateText != null)
            _view.TextFromBox = _model.PrevStateText;
        }
    }
}

public enum ButtonName
{
    Open,
    New,
    Save,
    SaveAs,
    Copy,
    Paste,
    Cut,
    SelectAll,
    Cancel,
    Exit
}

public class MyEventArgs : EventArgs
{
    public ButtonName ButtonName { get; set; }
    public MyEventArgs(ButtonName buttonName)
    {
        ButtonName = buttonName;
    }
}
