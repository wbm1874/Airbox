using Airbox.Services;
using Airbox.ViewModels;
using Airbox.Views;
using Microsoft.Extensions.Logging;

namespace Airbox
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMarkup()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Views
            builder.Services
                .AddSingleton<ImageListView>()
                .AddSingleton<MainPage>()
                .AddTransient<ImageView>();

            // View-models
            builder.Services
                .AddSingleton<ImageListViewModel>()
                .AddSingleton<MainPageViewModel>();

            // Services
            builder.Services
                .AddSingleton<IDeviceInformation, DeviceInformation>()
                .AddSingleton<INavigationService, NavigationService>();

#if DEBUG
		    builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}