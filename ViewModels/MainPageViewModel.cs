using Airbox.Models;
using Airbox.Services;
using Airbox.Views;

namespace Airbox.ViewModels
{
    public partial class MainPageViewModel(INavigationService navigationService) : ViewModelBase
    {
        public IList<ImageList> ImageLists => new[]
        {
            new ImageList(AppResources.Cars, new [] { "Images/car.jpg", "Images/car.jpg" }),
            new ImageList(AppResources.Helicopters, new [] { "Images/helicopter.jpg", "Images/helicopter.jpg", "Images/helicopter.jpg", "Images/helicopter.jpg" }),
            new ImageList(AppResources.Boats, new [] { "Images/boat.jpg", "Images/boat.jpg", "Images/boat.jpg", "Images/boat.jpg", "Images/boat.jpg", "Images/boat.jpg", "Images/boat.jpg", "Images/boat.jpg" }),
        };

        [RelayCommand]
        public async Task NavigateToImageList(ImageList imageList)
        {
            await navigationService.NavigateTo<ImageListViewModel>(imageList);
        }
    }
}
