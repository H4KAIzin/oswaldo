namespace oswaldo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void buttonStarted(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage ();
	}	

	private void buttonInf(object sender, EventArgs args)
	{
		Framas.IsVisible = true;
	}	

	private void ClickedBack(object sender, EventArgs args)
	{
		Framas.IsVisible = false;
	}	
}

