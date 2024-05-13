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
using System.Windows.Shapes;

namespace MayExamDenielsVarava
{
    /// <summary>
    /// Interaction logic for CustomerSearch.xaml
    /// </summary>
    public partial class CustomerSearch : Window
    {
        private RestaurantData db = new RestaurantData();

        public CustomerSearch()
        {
            InitializeComponent();
        }

        private void tbxCustomerName_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string customerName = tbxCustomerName.Text;
            string customerNumber = tbxContactNumber.Text;
        }
    }
}
