namespace MauiApp2;

public partial class InputControlDemo : ContentPage
{
	public InputControlDemo()
	{
		InitializeComponent();
	}

    private void Slide_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		LblSlider.Text = Slide.Value.ToString();
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if ( Stepper != null )
        {
            LblSlider.Text = Stepper.Value.ToString();
        }
    }
}