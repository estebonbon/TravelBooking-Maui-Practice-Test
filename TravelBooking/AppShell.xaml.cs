using TravelBooking.Views;

namespace TravelBooking
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("BookingPage", typeof(BookingPage));
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await DisplayAlert("About", "Welcome to TravelBooking!", "OK");
        }
    }
}
