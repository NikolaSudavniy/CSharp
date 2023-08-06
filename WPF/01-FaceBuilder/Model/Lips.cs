using System.Collections.ObjectModel;

namespace FaceBuilder.Model
{
    public class Lips
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
                "Images/Lips1.jpg",
                "Images/Lips2.jpg",
                "Images/Lips3.jpg",
                "Images/Lips4.jpg",
                "Images/Lips5.jpg",
                "Images/Lips6.jpg",
                "Images/Lips7.jpg"
            };
        }
    }
}