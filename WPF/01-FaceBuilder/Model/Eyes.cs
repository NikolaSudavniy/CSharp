using System.Collections.ObjectModel;

namespace FaceBuilder.Model
{
    public class Eyes
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
                "Images/Eyes1.jpg",
                "Images/Eyes2.jpg",
                "Images/Eyes3.jpg",
                "Images/Eyes4.jpg",
                "Images/Eyes5.jpg",
                "Images/Eyes6.jpg"
            };
        }
    }
}