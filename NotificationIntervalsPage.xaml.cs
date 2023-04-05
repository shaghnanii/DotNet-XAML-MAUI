using CommunityToolkit.Maui.Views;

namespace IntegrateX;

public partial class NotificationIntervalsPage : ContentPage
{
	public NotificationIntervalsPage()
	{
		InitializeComponent();
	}


	private void OnCloseClicked(object sender, EventArgs e)
	{
        this.ShowPopup(new LogoutConfirmModal());
    }

	private async void GotoMappingPage(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MappingPage");
	}
}