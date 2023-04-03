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
		await Shell.Current.GoToAsync("//LoginPage");
	}
}

