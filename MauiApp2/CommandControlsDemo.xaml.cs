namespace MauiApp2;

public partial class CommandControlsDemo : ContentPage
{
	public CommandControlsDemo()
	{
		InitializeComponent();
	}

   
    private void btnTest_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Test", "This is demo", "OK");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Radio Button", $"Change: {e.Value}", "OK");

    }

    private void SearchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Search Bar Control", $"Search: {SearchControl.Text}", "OK");

    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Swipe Control", $"Element Tap", "OK");

    }
}