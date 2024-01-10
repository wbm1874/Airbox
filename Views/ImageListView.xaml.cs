using Airbox.ViewModels;

namespace Airbox.Views;

public partial class ImageListView : ContentPage
{
	public ImageListView(ImageListViewModel viewModel)
	{
		InitializeComponent();
    
        BindingContext = viewModel;
	}
}