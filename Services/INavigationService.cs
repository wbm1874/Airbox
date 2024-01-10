namespace Airbox.Services;

public interface INavigationService
{
    Task NavigateTo<TViewModel>(object parameter = default);
}