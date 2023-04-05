using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;
using System.Threading;

namespace IntegrateX;

public partial class MappingPage : ContentPage
{
	public MappingPage()
	{
		InitializeComponent();
	}

    private void OnCloseClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new LogoutConfirmModal());
    }

    private async void GotoNotificationPage(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//NotificationIntervalsPage");
	}

	private void ShowToast(object sender, EventArgs e)
	{
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		var toast = Toast.Make("IntegrateX is ready...");
		toast.Show(cancellationTokenSource.Token);
	}
}