using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MayExamDenielsVarava
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RestaurantData db = new RestaurantData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dtpDetailsBookingDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDate = dtpDetailsBookingDate.SelectedDate;

            if (selectedDate != null)
            {
                var bookings = db.Bookings
                    .Where(b => b.BookingsDate.Year == selectedDate.Value.Year
                        && b.BookingsDate.Month == selectedDate.Value.Month
                        && b.BookingsDate.Day == selectedDate.Value.Day)
                    .ToList();

                lbxBookingsDetails.ItemsSource = bookings;

                var NumberOfBookings = bookings.Count;
                var availableBookings = 40 - NumberOfBookings;

                tblBookings.Text = NumberOfBookings.ToString();

                // Display "No Available Bookings" if it's less than 0
                tblAvailableBookings.Text = availableBookings > 0 ? availableBookings.ToString() : "No Available Bookings";
            }
        }

        private void btnDeleteBooking_Click(object sender, RoutedEventArgs e)
        {
            var selectedBooking = lbxBookingsDetails.SelectedItem as Booking;

            if (selectedBooking != null)
            {
                db.Bookings.Remove(selectedBooking);
                db.SaveChanges();
            }

        }

        private void brnCustomerSearch_Click(object sender, RoutedEventArgs e)
        {
            CustomerSearch customerSearchWindow = new CustomerSearch();
            customerSearchWindow.Show();
        }
    }
}
