using Airbox.Models;
using Airbox.ViewModels;
using Airbox.Views;

namespace Airbox.Services
{
    public class NavigationService(IServiceProvider serviceProvider) : INavigationService
    {
        public async Task NavigateTo<TViewModel>(object parameter = default)
        {
            var vm = serviceProvider.GetService<TViewModel>();
            Page view = null;

            switch (vm)
            {
                case ImageListViewModel imageListViewModel:
                    if (parameter is ImageList imageList)
                    {
                        imageListViewModel.ImageList = imageList;
                        view = serviceProvider.GetService<ImageListView>();
                    }
                    else
                    {
                        throw new InvalidOperationException($"Invalid ImageList parameter: {parameter}");
                    }
                    break;
            }

            if (view != null)
            {
                await App.Root.Navigation.PushAsync(view);
            }
            else
            {
                throw new InvalidOperationException($"Could not route {typeof(TViewModel)}");
            }
        }
    }
}
