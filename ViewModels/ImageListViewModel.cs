using Airbox.Models;
using Airbox.Services;

namespace Airbox.ViewModels
{
    public partial class ImageListViewModel(IDeviceInformation deviceInformation) : ViewModelBase
    {
        [ObservableProperty]
        private string _selectedImage;

        [ObservableProperty]
        private ImageList _imageList;

        [ObservableProperty]
        private int _span = 1;

        [ObservableProperty]
        private double _imageWidth;

        partial void OnSelectedImageChanged(string value)
        {

        }

        partial void OnImageListChanging(ImageList value)
        {
            var numImages = value.Files.Count;

            var size = deviceInformation.GetDisplaySize();

            switch (numImages)
            {
                case < 3:
                    this.Span = 1;
                    break;
                case < 7:
                    this.Span = 2;
                    break;
                default:
                    this.Span = 3;
                    break;
            }

            this.ImageWidth = (size.Width / (double)this.Span) - (8 * this.Span);
        }
    }
}
