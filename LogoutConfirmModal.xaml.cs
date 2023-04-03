using CommunityToolkit.Maui.Views;

namespace IntegrateX;

public partial class LogoutConfirmModal : Popup
{
	public LogoutConfirmModal()
	{
		InitializeComponent();
	}

    private void CloseLogoutConfirmModal(object sender, EventArgs e)
    {
        this.Close();
    }

    private async void CloseAndGotoLoginPage(object sender, EventArgs e)
    {
        this.Close();
        await Shell.Current.GoToAsync("//LoginPage");
    }
}