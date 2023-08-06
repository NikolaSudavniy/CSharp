using System.Collections.ObjectModel;

namespace ImageEditor.Model
{
    public class DataArray
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
                "Images/Rectangle 1.png",
                "Images/Rectangle 2.png",
                "Images/Rectangle 3.png",
                "Images/Rectangle 4.png",
                "Images/Rectangle 5.png",
                "Images/Rectangle 6.png"
            };
        }
    }
}