namespace TravelBooking.Views;

[QueryProperty(nameof(Destination), "destination")]
public partial class BookingPage : ContentPage
{
	private string destination = string.Empty;
	public string Destination {
		get => destination;
		set
		{
			destination = value;
			OnPropertyChanged(nameof(Destination));
		}

	}

    public BookingPage()
	{
		InitializeComponent();
		//Set binding context
		BindingContext = this;
	}

    private async void btnReturnMain_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(".."); //Go back one page
    }

    private async void Pastry_Tapped(object sender, TappedEventArgs e)
    {
        mediaSound.Play();

        await DisplayAlert("Snack Shack", "Pastry selected", "Ok");
    }

    private void Pastry_SwipedLeft(object sender, SwipedEventArgs e)
    {
        if (e.Direction == SwipeDirection.Left)
        {
            imgPastry.ScaleX = -1;
        }
        else if (e.Direction == SwipeDirection.Right)
        {
            imgPastry.ScaleX = 1;
        }
        else if (e.Direction == SwipeDirection.Up)
        {
            imgPastry.ScaleY = 1;
        }
        else
        {
            imgPastry.ScaleY = -1;
        }
    }
}