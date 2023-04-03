using CommunityToolkit.Maui.Views;

namespace IntegrateX;

public partial class VerifyIdentityModalPage : Popup
{
	public VerifyIdentityModalPage()
	{
		InitializeComponent();
	}


	private void CloseVerifyModal(object sender, EventArgs e)
	{
		this.Close();
	}

	private async void OpenNotificationIntervalsPage(object sender, EventArgs e)
	{
        this.Close();
        await Shell.Current.GoToAsync("//NotificationIntervalsPage");
    }
}