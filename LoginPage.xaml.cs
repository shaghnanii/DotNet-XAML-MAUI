namespace IntegrateX;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private async void GotoDashboard(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}