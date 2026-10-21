namespace TravelBooking.Views;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    private async void btnClose_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}