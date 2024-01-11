using Airbox.Models;
using Airbox.Services;

namespace Airbox.ViewModels;

public partial class ImageListViewModel(IDeviceInformation deviceInformation) : ViewModelBase
{
    [ObservableProperty]
    private string? _selectedImage;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsFullScreenVisible))]
    private string? _fullScreenImage;

    [ObservableProperty]
    private ImageList? _imageList;

    [ObservableProperty]
    private int _span = 1;

    [ObservableProperty]
    private double _imageWidth;

    public bool IsFullScreenVisible => !string.IsNullOrEmpty(this.FullScreenImage);

    [RelayCommand]
    public void HideFullScreenView()
    {
        this.FullScreenImage = null;
    }

    partial void OnImageListChanging(ImageList? value)
    {
        var size = deviceInformation.GetDisplaySize();

        this.Span = GetSpanForImageList(value);

        this.ImageWidth = (size.Width / (double)this.Span) - (8 * this.Span);

        this.HideFullScreenView();
    }

    partial void OnSelectedImageChanged(string? value)
    {
        if (value is null) return;

        this.FullScreenImage = value;
        this.SelectedImage = null;
    }

    private static int GetSpanForImageList(ImageList? imageList)
    {
        var numImages = (imageList?.Files.Count).GetValueOrDefault();

        return numImages switch
        {
            < 3 => 1,
            < 7 => 2,
            _ => 3
        };
    }
}
