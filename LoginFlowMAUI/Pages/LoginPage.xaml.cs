using LoginFlowMAUI.Services;

namespace LoginFlowMAUI.Pages;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;

    public LoginPage(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        _authService.Login();
		await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}