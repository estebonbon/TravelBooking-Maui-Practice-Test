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
    }
}
