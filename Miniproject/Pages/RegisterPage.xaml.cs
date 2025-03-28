using Miniproject.Viewmodel;

namespace Miniproject.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
		BindingContext = new RegisterViewmodel();
	}
}