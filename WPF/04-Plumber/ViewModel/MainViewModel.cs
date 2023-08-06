using Plumber.Model;
using System;
using System.Windows.Input;

namespace Plumber.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Image10 = StraightPipe.AllImages[1];
            Image11 = TurnedPipe.AllImages[0];
            Image12 = StraightPipe.AllImages[0];
            Image13 = TurnedPipe.AllImages[0];

            Image20 = TurnedPipe.AllImages[2];
            Image21 = TurnedPipe.AllImages[3];
            Image22 = TurnedPipe.AllImages[1];
            Image23 = StraightPipe.AllImages[1];

            Image30 = "Images/Empty.jpg";
            Image31 = TurnedPipe.AllImages[1];
            Image32 = StraightPipe.AllImages[0];
            Image33 = TurnedPipe.AllImages[3];

            FooterPipe = FooterPipes.AllImages[0];
        }

        #region Image Binding Property

        private string _image10;
        private string _image11;
        private string _image12;
        private string _image13;
        private string _image20;
        private string _image21;
        private string _image22;
        private string _image23;
        private string _image30;
        private string _image31;
        private string _image32;
        private string _image33;

        public string Image10
        {
            get => _image10;
            set
            {
                _image10 = value;
                OnPropertyChanged(nameof(Image10));
            }
        }

        public string Image11
        {
            get => _image11;
            set
            {
                _image11 = value;
                OnPropertyChanged(nameof(Image11));
            }
        }

        public string Image12
        {
            get => _image12;
            set
            {
                _image12 = value;
                OnPropertyChanged(nameof(Image12));
            }
        }

        public string Image13
        {
            get => _image13;
            set
            {
                _image13 = value;
                OnPropertyChanged(nameof(Image13));
            }
        }

        public string Image20
        {
            get => _image20;
            set
            {
                _image20 = value;
                OnPropertyChanged(nameof(Image20));
            }
        }

        public string Image21
        {
            get => _image21;
            set
            {
                _image21 = value;
                OnPropertyChanged(nameof(Image21));
            }
        }

        public string Image22
        {
            get => _image22;
            set
            {
                _image22 = value;
                OnPropertyChanged(nameof(Image22));
            }
        }

        public string Image23
        {
            get => _image23;
            set
            {
                _image23 = value;
                OnPropertyChanged(nameof(Image23));
            }
        }

        public string Image30
        {
            get => _image30;
            set
            {
                _image30 = value;
                OnPropertyChanged(nameof(Image30));
            }
        }

        public string Image31
        {
            get => _image31;
            set
            {
                _image31 = value;
                OnPropertyChanged(nameof(Image31));
            }
        }

        public string Image32
        {
            get => _image32;
            set
            {
                _image32 = value;
                OnPropertyChanged(nameof(Image32));
            }
        }

        public string Image33
        {
            get => _image33;
            set
            {
                _image33 = value;
                OnPropertyChanged(nameof(Image33));
            }
        }

        private string _footerPipe;

        public string FooterPipe
        {
            get => _footerPipe;
            set
            {
                _footerPipe = value;
                OnPropertyChanged(nameof(FooterPipe));
            }
        }

        #endregion

        #region Action for pipe-buttons

        private RelayCommand _turnTurned;

        public ICommand TurnTurned
        {
            get
            {
                if (_turnTurned == null)
                    _turnTurned = new RelayCommand(ExecuteTurned);
                return _turnTurned;
            }
        }

        public void ExecuteTurned(object buttonName)
        {
            int propertyIndex = int.Parse(buttonName as string);

            var fi = typeof(MainViewModel).GetProperty("Image" + propertyIndex);

            string imagePath = Convert.ToString(fi.GetValue(this));
            int imageIndex = int.Parse(imagePath.Substring(imagePath.Length - 5, 1));

            fi.SetValue(this, TurnedPipe.AllImages[imageIndex == 3 ? 0 : imageIndex + 1]);

            OnPropertyChanged(fi.Name);
        }

        private RelayCommand _turnStraight;

        public ICommand TurnStraight
        {
            get
            {
                if (_turnStraight == null)
                    _turnStraight = new RelayCommand(ExecuteStraight);
                return _turnStraight;
            }
        }

        public void ExecuteStraight(object buttonName)
        {
            int propertyIndex = int.Parse(buttonName as string);

            var fi = typeof(MainViewModel).GetProperty("Image" + propertyIndex);

            string imagePath = Convert.ToString(fi.GetValue(this));
            int imageIndex = int.Parse(imagePath.Substring(imagePath.Length - 5, 1));

            fi.SetValue(this, StraightPipe.AllImages[imageIndex == 1 ? 0 : 1]);
        }

        #endregion

        #region Action for opening crane

        private RelayCommand _openCrane;

        public ICommand OpenCrane
        {
            get
            {
                if (_openCrane == null)
                    _openCrane = new RelayCommand(ExecuteOpenCrane);
                return _openCrane;
            }
        }

        public void ExecuteOpenCrane(object parameter)
        {
            if (IsVictoriousCombination())
            {
                SetImagesOfPipesWithWater();
            }
        }

        private bool IsVictoriousCombination()
        {
            return
                StraightPipe.AllImages.IndexOf(Image10) == 0 &&
                TurnedPipe.AllImages.IndexOf(Image11) == 0 &&
                StraightPipe.AllImages.IndexOf(Image12) == 1 &&
                TurnedPipe.AllImages.IndexOf(Image13) == 1 &&

                TurnedPipe.AllImages.IndexOf(Image20) == 3 &&
                TurnedPipe.AllImages.IndexOf(Image21) == 2 &&
                StraightPipe.AllImages.IndexOf(Image23) == 0 &&

                TurnedPipe.AllImages.IndexOf(Image31) == 0 &&
                StraightPipe.AllImages.IndexOf(Image32) == 1 &&
                TurnedPipe.AllImages.IndexOf(Image33) == 2;
        }

        private void SetImagesOfPipesWithWater()
        {
            Image10 = StraightPipeWithWather.AllImages[0];
            Image11 = TurnedPipeWithWater.AllImages[0];
            Image12 = StraightPipeWithWather.AllImages[1];
            Image13 = TurnedPipeWithWater.AllImages[1];
            Image20 = TurnedPipeWithWater.AllImages[3];
            Image21 = TurnedPipeWithWater.AllImages[2];
            Image23 = StraightPipeWithWather.AllImages[0];
            Image31 = TurnedPipeWithWater.AllImages[0];
            Image32 = StraightPipeWithWather.AllImages[1];
            Image33 = TurnedPipeWithWater.AllImages[2];
            FooterPipe = FooterPipes.AllImages[1];
        }

        #endregion
    }
}