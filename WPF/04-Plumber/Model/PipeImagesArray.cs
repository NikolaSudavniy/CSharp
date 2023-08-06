using System.Collections.ObjectModel;

namespace Plumber.Model
{
    public class TurnedPipe
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
                "Images/TurnPipe0.jpg",
                "Images/TurnPipe1.jpg",
                "Images/TurnPipe2.jpg",
                "Images/TurnPipe3.jpg",
            };
        }
    }

    public class TurnedPipeWithWater
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
                "Images/TurnPipeWithWater0.jpg",
                "Images/TurnPipeWithWater1.jpg",
                "Images/TurnPipeWithWater2.jpg",
                "Images/TurnPipeWithWater3.jpg",
            };
        }
    }

    public class StraightPipe
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
                "Images/StraightPipe0.jpg",
                "Images/StraightPipe1.jpg",
            };
        }
    }

    public class StraightPipeWithWather
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
                "Images/StraightPipeWithWater0.jpg",
                "Images/StraightPipeWithWater1.jpg",
            };
        }
    }

    public class FooterPipes
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
                "/Images/DownPipeFinish0.jpg",
                "/Images/DownPipeFinish1.jpg"
            };
        }
    }
}