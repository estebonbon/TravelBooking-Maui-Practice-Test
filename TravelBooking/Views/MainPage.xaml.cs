namespace TravelBooking.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            //Immediate opem

            NavigatedTo += MainPage_NavigatedTo;
        }

        private async void btnflight_Clicked(object sender, EventArgs e) //Make it Async
        {
            await DisplayAlert("Booking", "Your Flight has been booked", "Ok");
        }

        private async void btncancel_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert(
                "Cancel Booking",
                "Are you sure you want to cancel",
                "Yes",
                "No");

            if(answer)
            {
                await DisplayAlert("Booking", "Your booking has been cancelled", "Ok");
            }
            else
            { 
                    await DisplayAlert("Booking", "Your booking has not been cancelled", "Ok");
            }
        }

        private async void btnpassenger_Clicked(object sender, EventArgs e)
        {
            string? name = await DisplayPromptAsync(
                "Passenger Details",
                "What is your name?"

                );

            if (!string.IsNullOrWhiteSpace(name))
            {
                await DisplayAlert("Welcome", $"Welcome aboard, {name}!", "Ok");
            }
        }

        private async void btnAction_Clicked(object sender, EventArgs e)
        {
            string? choice = await DisplayActionSheet(
                "Select a travel class",
                "Cancel",
                null,
                "Economy",
                "Business",
                "First Class"
                );

            if(!string.IsNullOrWhiteSpace(choice)) {
                await DisplayAlert("Travel Class", $"You selected {choice}!", "Ok");
            }
        }

        private async void btnDestination_Clicked(object sender, EventArgs e)
        {
            string? destination = await DisplayActionSheet(
                "Select a Destination",
                "Cancel",
                null,
                "Athens",
                "London",
                "Rome"
                );

            if (!string.IsNullOrWhiteSpace(destination))
            {
                bool answer = await DisplayAlert("Confirm", $"Are you sure you want to travel to {destination}", "yes", "no");

                if (answer)
                {
                    await DisplayAlert("Booking", $"Your destination is now {destination}!", "Ok");
                }
            }
        }

        private async void btnGoBook_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("BookingPage");
        }

        private async void btnBookValue_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("BookingPage?destination=Athens");
        }

        private async void btnOpenModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage());
        }

        private bool modalShown = false;

        private async void MainPage_NavigatedTo(object sender, NavigatedToEventArgs e)
        {
            if(!modalShown)
            {
                modalShown = true;
                await Navigation.PushModalAsync(new ModalPage());
            }
        }
    }
}
