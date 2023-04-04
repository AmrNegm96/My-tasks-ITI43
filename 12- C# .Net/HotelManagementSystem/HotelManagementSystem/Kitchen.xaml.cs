using Dapper;
using HotelManagementSystem.Entities;
using HotelManagementSystem.HotelContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
    /// Interaction logic for Kitchen.xaml
    /// </summary>
    public partial class Kitchen : Window
    {
        Context context;
        IDbConnection dapperDbConnection;
        public Kitchen()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            context = new Context();
            dapperDbConnection = context.Database.GetDbConnection();
            context.Reservations.Load();
            DataInitialization();
        }
        public void DataInitialization()
        {
            //grdReservation.ItemsSource = context.Reservations.ToList();  //Overview 
            //queueListBox.ItemsSource = context.Reservations.ToList(); //List

            grdReservation.ItemsSource = dapperDbConnection.Query<Reservation>("Select * from reservations")?.ToList() ?? new();
            queueListBox.ItemsSource = dapperDbConnection.Query<Reservation>("Select * from reservations")?.ToList() ?? new();
            queueListBox.SelectedValuePath = "ID";
            queueListBox.DisplayMemberPath = "RoomNumber";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedID;
            if (queueListBox.SelectedItem is Reservation rsrv)
            {
                selectedID = rsrv.Id;
                Reservation? r = dapperDbConnection.QueryFirstOrDefault<Reservation>("Select * from Reservations where Id = @ResID", new { ResID = selectedID });

                FoodMenu foodMenu = new FoodMenu(r);
                if (r.BreakFast > 0)
                {
                    foodMenu.CboxBreakfast.IsChecked = true;
                    foodMenu.txtBreakfastQuantity.Text = r.BreakFast.ToString();
                }
                if (r.Lunch > 0)
                {
                    foodMenu.CboxLunch.IsChecked = true;
                    foodMenu.txtLunchQuantity.Text = r.Lunch.ToString();
                }
                if (r.Dinner > 0)
                {
                    foodMenu.CboxDinner.IsChecked = true;
                    foodMenu.txtDinnerQuantity.Text = r.Dinner.ToString();
                }
                if(r.Cleaning == true)
                {
                    foodMenu.CboxCleaning.IsChecked = true;
                }
                if (r.Towel == true)
                {
                    foodMenu.CboxTowels.IsChecked = true;
                }
                if (r.SSurprise == true)
                {
                    foodMenu.CboxGifts.IsChecked = true;
                }
                if (!foodMenu.IsActive)
                {
                    foodMenu.ShowDialog();
                }
            }
        }
        

        private void queueListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedID;
            Reservation? reservation;
            if (queueListBox.SelectedItem is Reservation rsrv)
            {
                selectedID = rsrv.Id;
                //reservation = context.Reservations.Find(selectedID);

                Reservation? reservation = dapperDbConnection.QueryFirstOrDefault<Reservation>("Select * from Reservations where Id = @ResID", new { ResID = selectedID });
                if (reservation != null)
                {
                    txtfirstName.Text = reservation.FirstName;
                    txtLastName.Text = reservation.LastName;
                    txtPhone.Text = reservation.PhoneNumber;
                    txtRoomType.Text = reservation.RoomType.ToString().Trim();
                    txtRoomNumber.Text = reservation.RoomNumber.ToString().Trim();
                    txtFloorNumber.Text = reservation.RoomFloor.ToString().Trim();

                    txtBreakfastQTY.Text = reservation.BreakFast.ToString();
                    txtLunchQTY.Text = reservation.Lunch.ToString();
                    txtDinnerQTY.Text = reservation.Dinner.ToString();

                    CboxCleaning.IsChecked = reservation.Cleaning;
                    CboxTowels.IsChecked = reservation.Towel;
                    CboxGift.IsChecked = reservation.SSurprise;
                }
            }
            

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
