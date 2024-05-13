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
            }
        }

        private void UpdateBookingsInfo()
        {
            var selectedDate = dtpDetailsBookingDate.SelectedDate;

            if (selectedDate != null)
            {

            }
        }
    }
}
