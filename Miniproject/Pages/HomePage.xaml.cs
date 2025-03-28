using Miniproject.Viewmodel;

namespace Miniproject.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomeViewmodel();
	}
}