using Miniproject.Viewmodel;

namespace Miniproject.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewmodel();
	}
}