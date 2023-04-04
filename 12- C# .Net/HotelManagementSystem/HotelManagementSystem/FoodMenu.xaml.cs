using HotelManagementSystem.Entities;
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

namespace HotelManagementSystem
{
    /// <summary>
    /// Interaction logic for FoodMenu.xaml
    /// </summary>
    public partial class FoodMenu : Window
    {
        int breakfastQ = 0;
        int dinnerQ = 0;
        int lunchQ = 0;
        bool towels = false; 
        bool cleaning = false;
        bool gifts = false;

        public int BreakfastQ { get { return breakfastQ; } set { breakfastQ = value; } }
        public int DinnerQ { get { return dinnerQ; } set { dinnerQ = value; } }
        public int LunchQ { get { return lunchQ; } set { lunchQ = value; } }
        public bool Towels { get { return towels; } set { towels = value; } }
        public bool Gifts { get { return gifts; } set { gifts = value; } }
        public bool Cleaning { get { return cleaning; } set { cleaning = value; } }

        public FoodMenu(Reservation? rsrv)
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            txtBreakfastQuantity.IsEnabled = false;
            txtDinnerQuantity.IsEnabled = false;
            txtLunchQuantity.IsEnabled = false;
        }

        private void CboxBreakfast_Checked(object sender, RoutedEventArgs e)
        {
            txtBreakfastQuantity.IsEnabled = true;
        }

        private void CboxLunch_Checked(object sender, RoutedEventArgs e)
        {
            txtLunchQuantity.IsEnabled = true;
        }

        private void CboxDinner_Checked(object sender, RoutedEventArgs e)
        {
            txtDinnerQuantity.IsEnabled = true;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if(txtBreakfastQuantity.Text != string.Empty)
            {
                breakfastQ = int.Parse(txtBreakfastQuantity.Text.ToString());
            }
            if (txtLunchQuantity.Text != string.Empty)
            {
                LunchQ = int.Parse(txtLunchQuantity.Text.ToString());
            }
            if (txtDinnerQuantity.Text != string.Empty)
            {
                dinnerQ = int.Parse(txtDinnerQuantity.Text.ToString());
            }
            if(CboxCleaning.IsChecked == true)
            {
                cleaning = true;
            }
            if (CboxTowels.IsChecked == true)
            {
                towels = true;
            }
            if (CboxGifts.IsChecked == true)
            {
                gifts = true;
            }

            this.Close();

        }
    }
}
