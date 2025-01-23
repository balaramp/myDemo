using myDemo.ViewModels;

namespace myDemo.Views;

public partial class MapsPage: ContentPage
{
	public MapsPage(MapsPageViewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}