using System.Collections.ObjectModel;

namespace FaceBuilder.Model
{
    public class Brows
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
                "Images/Eyebrows1.jpg",
                "Images/Eyebrows2.jpg",
                "Images/Eyebrows3.jpg"
            };
        }
    }
}