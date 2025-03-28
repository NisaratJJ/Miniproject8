using Miniproject.Viewmodel;

namespace Miniproject.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
		BindingContext = new ProfileViewmodel();
	}
}