using System.Collections.ObjectModel;

namespace FaceBuilder.Model
{
    public class Nose
    {
        private static ObservableCollection<string> _images;

        public static ObservableCollection<string> AllImages
        {
            get
            {
                if (_images == null)
                    _images = DownloadImages();
                return _images;
            }
        }

        private static ObservableCollection<string> DownloadImages()
        {
            return new ObservableCollection<string>
            {
                "Images/Nose1.jpg",
                "Images/Nose2.jpg",
                "Images/Nose3.jpg",
                "Images/Nose4.jpg",
                "Images/Nose5.jpg"
            };
        }
    }
}