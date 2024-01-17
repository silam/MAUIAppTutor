using System.Diagnostics;

namespace MauiApp2;

public partial class TextControlDemo : ContentPage
{
	public TextControlDemo()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine(EntryText.Text);
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(EntryText.Text);
    }
}