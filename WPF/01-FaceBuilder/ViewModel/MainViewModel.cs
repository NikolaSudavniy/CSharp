using FaceBuilder.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;

namespace FaceBuilder.ViewModel
{
    public class MainViewModel :BaseViewModel
    {
        private FacesManager _faces;

        public MainViewModel()
        {
            ImagePathOfEyebrows = "Images/Eyebrows1.jpg";
            ImagePathOfEyes = "Images/Eyes1.jpg";
            ImagePathOfNose = "Images/Nose1.jpg";
            ImagePathOfLips = "Images/Lips1.jpg";

            TemplateFaceNames = new ObservableCollection<string>();
            _faces = new FacesManager();

            if (File.Exists(_faces.FileName))
            {
                _faces.Load();
                foreach (var face in _faces.FacesArray)
                    TemplateFaceNames.Add(face.ToString());
            }
        }

        #region Binding of face parts

        private string _imagePathOfEyebrows;

        public string ImagePathOfEyebrows
        {
            get => _imagePathOfEyebrows;
            set
            {
                _imagePathOfEyebrows = value;
                OnPropertyChanged(nameof(ImagePathOfEyebrows));
            }
        }

        private string _imagePathOfEyes;

        public string ImagePathOfEyes
        {
            get => _imagePathOfEyes;
            set
            {
                _imagePathOfEyes = value;
                OnPropertyChanged(nameof(ImagePathOfEyes));
            }
        }

        private string _imagePathOfNose;

        public string ImagePathOfNose
        {
            get => _imagePathOfNose;
            set
            {
                _imagePathOfNose = value;
                OnPropertyChanged(nameof(ImagePathOfNose));
            }
        }

        private string _imagePathOfLips;

        public string ImagePathOfLips
        {
            get => _imagePathOfLips;
            set
            {
                _imagePathOfLips = value;
                OnPropertyChanged(nameof(ImagePathOfLips));
            }
        }

        #endregion

        #region Binding combo-boxes

        public int ComboBoxIndexOfEyeBrows { get; set; }
        public int ComboBoxIndexOfEyes { get; set; }
        public int ComboBoxIndexOfNose { get; set; }
        public int ComboBoxIndexOfLips { get; set; }

        #endregion

        #region Binding another properties

        private string _selectedFaceToLoad;

        public string SelectedFaceToLoad
        {
            get => _selectedFaceToLoad;
            set
            {
                _selectedFaceToLoad = value;
                OnPropertyChanged(nameof(SelectedFaceToLoad));
            }
        }

        private string _newTemplateFaceName;

        public string NewTemplateFaceName
        {
            get => _newTemplateFaceName;
            set
            {
                _newTemplateFaceName = value;
                OnPropertyChanged(nameof(NewTemplateFaceName));
            }
        }

        private ObservableCollection<string> _templateFaceNames;

        public ObservableCollection<string> TemplateFaceNames
        {
            get => _templateFaceNames;
            set
            {
                _templateFaceNames = value;
                OnPropertyChanged(nameof(TemplateFaceNames));
            }
        }

        #endregion

        #region Commands

        private RelayCommand _selectedImageChange;

        public ICommand SelectedImageChange
        {
            get
            {
                if (_selectedImageChange == null)
                    _selectedImageChange = new RelayCommand(ExecuteChangingImage);
                return _selectedImageChange;
            }
        }

        public void ExecuteChangingImage(object parameter)
        {
            string facePart = (string)parameter;

            switch (facePart)
            {
                case "Brows":
                    ImagePathOfEyebrows = Brows.AllImages[ComboBoxIndexOfEyeBrows];
                    break;
                case "Eye":
                    ImagePathOfEyes = Eyes.AllImages[ComboBoxIndexOfEyes];
                    break;
                case "Nose":
                    ImagePathOfNose = Nose.AllImages[ComboBoxIndexOfNose];
                    break;
                case "Lips":
                    ImagePathOfLips = Lips.AllImages[ComboBoxIndexOfLips];
                    break;
            }
        }

        private RelayCommand _saveNewFace;
        public ICommand SaveNewFace
        {
            get
            {
                if (_saveNewFace == null)
                    _saveNewFace = new RelayCommand(ExecuteSavingNewTemplateFace);
                return _saveNewFace;
            }
        }

        public void ExecuteSavingNewTemplateFace(object parameter)
        {
            Face face = new Face()
            {
                FaceParts = new List<string>()
                {
                    NewTemplateFaceName,
                    ImagePathOfEyebrows,
                    ImagePathOfEyes,
                    ImagePathOfNose,
                    ImagePathOfLips
                }
            };

            NewTemplateFaceName = string.Empty;
            TemplateFaceNames.Add(face.ToString());
            _faces.FacesArray.Add(face);

        }

        private RelayCommand _windowClosing;

        public ICommand WindowClosing
        {
            get
            {
                if (_windowClosing == null)
                    _windowClosing = new RelayCommand(ExecuteSavingFaces);
                return _windowClosing;
            }
        }

        private void ExecuteSavingFaces(object parameter)
        {
            _faces.Save();
        }

        private RelayCommand _loadTemplateFace;

        public ICommand LoadTemplateFace
        {
            get
            {
                if (_loadTemplateFace == null)
                    _loadTemplateFace = new RelayCommand(ExecuteLoadTemplateFace);
                return _loadTemplateFace;
            }
        }

        private void ExecuteLoadTemplateFace(object template)
        {
            Face face = _faces.FacesArray.Where(r => r.FaceParts[0] == SelectedFaceToLoad).First();
            ImagePathOfEyebrows = face.FaceParts[1];
            ImagePathOfEyes = face.FaceParts[2];
            ImagePathOfNose = face.FaceParts[3];
            ImagePathOfLips = face.FaceParts[4];
        }

        #endregion
    }
}