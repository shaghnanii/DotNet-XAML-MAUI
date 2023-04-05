using CommunityToolkit.Maui.Views;

namespace IntegrateX;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	} 

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if (count < 9)
		{
            count++;
            NewOrders.Text = $"{count}";
		}
		else
		{
            NewOrders.Text = $"{count}+";
		}

        SemanticScreenReader.Announce(NewOrders.Text);
    }

	private async void OnCloseClicked(object sender, EventArgs e)
	{
        this.ShowPopup(new LogoutConfirmModal());
    }

	private void OpenVerifyIdentityModal(object sender, EventArgs e)
	{
		this.ShowPopup(new VerifyIdentityModalPage());

	}
}

