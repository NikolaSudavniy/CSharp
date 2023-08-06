using ImageEditor.Model;
using System;
using System.Windows.Input;

namespace ImageEditor.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            ResizingByHeight = 100;
            ResizingByWidth = 100;
            XaxisShift = 0;
            YaxisShift = 0;
            XaxisTilt = 0;
            YaxisTilt = 0;
            Rotate = 0;
        }

        #region Binding Property

        private string _imageForEditing;

        public string ImageForEditing
        {
            get => _imageForEditing;
            set
            {
                _imageForEditing = value;
                OnPropertyChanged(nameof(ImageForEditing));
            }
        }

        private int _imageHeight;

        public int ImageHeight
        {
            get => _imageHeight;
            set
            {
                _imageHeight = value;
                OnPropertyChanged(nameof(ImageHeight));
            }
        }

        private int _imageWidth;

        public int ImageWidth
        {
            get => _imageWidth;
            set
            {
                _imageWidth = value;
                OnPropertyChanged(nameof(ImageWidth));
            }
        }

        private int _imageRotate;

        public int ImageRotate
        {
            get => _imageRotate;
            set
            {
                _imageRotate = value;
                OnPropertyChanged(nameof(ImageRotate));
            }
        }

        private int _imageXaxisTilt;

        public int ImageXaxisTilt
        {
            get => _imageXaxisTilt;
            set
            {
                _imageXaxisTilt = value;
                OnPropertyChanged(nameof(ImageXaxisTilt));
            }
        }

        private int _imageXaxisShift;

        public int ImageXaxisShift
        {
            get => _imageXaxisShift;
            set
            {
                _imageXaxisShift = value;
                OnPropertyChanged(nameof(ImageXaxisShift));
            }
        }

        private int _imageYaxisTilt;

        public int ImageYaxisTilt
        {
            get => _imageYaxisTilt;
            set
            {
                _imageYaxisTilt = value;
                OnPropertyChanged(nameof(ImageYaxisTilt));
            }
        }

        private int _imageYaxisShift;

        public int ImageYaxisShift
        {
            get => _imageYaxisShift;
            set
            {
                _imageYaxisShift = value;
                OnPropertyChanged(nameof(ImageYaxisShift));
            }
        }

        private int _resizingByHeight;
        private int _resizingByWidth;
        private int _XaxisShift;
        private int _YaxisShift;
        private int _XaxisTilt;
        private int _YaxisTilt;
        private int _rotate;

        public int ResizingByHeight
        {
            get => _resizingByHeight;
            set
            {
                _resizingByHeight = value;
                ImageHeight = ResizingByHeight;
                OnPropertyChanged("ResizingByHeight");
            }
        }

        public int ResizingByWidth
        {
            get => _resizingByWidth;
            set
            {
                _resizingByWidth = value;
                ImageWidth = ResizingByWidth;
                OnPropertyChanged("ResizingByWidth");
            }
        }

        public int XaxisShift
        {
            get => _XaxisShift;
            set
            {
                _XaxisShift = value;
                ImageXaxisShift = XaxisShift;
                OnPropertyChanged("XaxisShift");
            }
        }

        public int YaxisShift
        {
            get => _YaxisShift;
            set
            {
                _YaxisShift = value;
                ImageYaxisShift = YaxisShift;
                OnPropertyChanged("YaxisShift");
            }
        }

        public int XaxisTilt
        {
            get => _XaxisTilt;
            set
            {
                _XaxisTilt = value;
                ImageXaxisTilt = XaxisTilt;
                OnPropertyChanged("XaxisTilt");
            }
        }

        public int YaxisTilt
        {
            get => _YaxisTilt;
            set
            {
                _YaxisTilt = value;
                ImageYaxisTilt = YaxisTilt;
                OnPropertyChanged("YaxisTilt");
            }
        }

        public int Rotate
        {
            get => _rotate;
            set
            {
                _rotate = value;
                ImageRotate = Rotate;
                OnPropertyChanged("Rotate");
            }
        }

        #endregion

        #region ICommand

        private RelayCommand _command;

        public ICommand SetImage
        {
            get
            {
                if (_command == null)
                    _command = new RelayCommand(ExecuteSetImage);
                return _command;
            }
        }

        public void ExecuteSetImage(object index)
        {
            ImageForEditing = DataArray.AllImages[Convert.ToInt32(index)];
        }

        #endregion
    }
}