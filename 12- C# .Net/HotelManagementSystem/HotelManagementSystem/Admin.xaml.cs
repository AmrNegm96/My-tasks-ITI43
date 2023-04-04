using Dapper;
using HotelManagementSystem.Entities;
using HotelManagementSystem.HotelContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        Context context;

        List<int> Months;
        List<int> Days;
        List<string> Genders;
        List<string> States;
        List<int> NumberOfGuests;
        List<int> Floor;
        List<int> RoomNumber;
        List<string> RoomType;
        Dictionary<string, int> RoomPrices;

        Reservation newReservation;
        FoodMenu foodMenu;

        IDbConnection dapperDbConnection;

        public Admin()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            context = new Context();

            //using dapper
            dapperDbConnection = context.Database.GetDbConnection();

            Days = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            Months = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Genders = new List<string>() { "Male", "Female" };
            States = new List<string>() { "Cairo", "Giza", "Alex", "Tanta", "Qena", "Aswan", "Mansoura", "Matrooh", "SharmElShek" };
            NumberOfGuests = new List<int>() { 1, 2, 3, 4 };
            Floor = new List<int>() { 1, 2, 3 };
            RoomNumber = new List<int>() { 100, 101, 102, 103, 104, 105, 200, 201, 202, 203, 204, 205, 300, 301, 302, 303, 304, 305 };
            RoomType = new List<string>() { "Single", "Double", "Suite", "Delux" };
            
            RoomPrices = new() { { "Single", 100 }, { "Double", 150 }, { "Delux", 250 }, { "Suite", 350 }, };
            context.Reservations.Load();

            DataInitialization();
        }
        public void DataInitialization()
        {
            //grdReservation.ItemsSource = context.Reservations.ToList();

            //using dapper
            grdReservation.ItemsSource = dapperDbConnection.Query<Reservation>("Select * from Reservations")?.ToList() ?? new();

            CboxAllReservations.Visibility = Visibility.Collapsed;
            btnDelete.Visibility = Visibility.Collapsed;
            btnUpdate.Visibility = Visibility.Collapsed;
            CboxDay.ItemsSource = Days;
            CboxMonth.ItemsSource = Months;
            CboxGender.ItemsSource = Genders;
            CboxState.ItemsSource = States;
            CboxGuestNumber.ItemsSource = NumberOfGuests;
            CboxFloor.ItemsSource = Floor;
            CboxRoomNumber.ItemsSource = RoomNumber;
            CboxRoomType.ItemsSource = RoomType;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
        private void btnFoodMenu_Click(object sender, RoutedEventArgs e)
        {
            int selectedID = Convert.ToInt32(CboxAllReservations.SelectedValue);

            //Reservation? reservation = context.Reservations.Find(selectedID);

            //using dapper
            Reservation? reservation = dapperDbConnection.QueryFirstOrDefault<Reservation>("Select * from Reservations where Id = @ResID", new { ResID = selectedID });


            foodMenu = new(reservation);

            if (!foodMenu.IsActive)
            {
                foodMenu.ShowDialog();
            }
        }
        private void btnNewReservation_Click(object sender, RoutedEventArgs e)
        {
            CleanUp();
            newReservation = new();
        }
        public void CleanUp()
        {
            txtFname.Text = String.Empty;
            txtLname.Text = String.Empty;
            txtYear.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtAppNo_.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtZipCode.Text = String.Empty;

            CboxDay.Text = String.Empty;
            CboxMonth.Text = String.Empty;
            CboxGender.Text = String.Empty;
            CboxState.Text = String.Empty;
            CboxGuestNumber.Text = String.Empty;
            CboxRoomNumber.Text = String.Empty;
            CboxRoomType.Text = String.Empty;
            CboxFloor.Text = String.Empty;

            dpStartdate.Text = String.Empty;
            dpEnddate.Text = String.Empty;

            CboxAllReservations.SelectedItem = null;
            CboxAllReservations.ItemsSource = context.Reservations.ToList();
            grdReservation.ItemsSource = context.Reservations.ToList();
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

            //using dapper
            CboxAllReservations.ItemsSource = dapperDbConnection.Query<Reservation>("Select * from Reservations")?.ToList() ?? new();

            //CboxAllReservations.ItemsSource = context.Reservations.ToList();
            CboxAllReservations.SelectedValuePath = "Id"; 
            CboxAllReservations.DisplayMemberPath = "FirstName";
            CboxAllReservations.SelectedIndex = 0; 
            CboxAllReservations.Visibility = Visibility.Visible;
            btnDelete.Visibility = Visibility.Visible;
            btnUpdate.Visibility = Visibility.Visible;
        }
        private void CboxAllReservations_DropDownClosed(object sender, EventArgs e)
        {
            int selectedID = int.Parse(CboxAllReservations.SelectedValue.ToString());

            //Reservation? reservation = context.Reservations.Find(selectedID);

            //using dapper
            Reservation? reservation = dapperDbConnection.QueryFirstOrDefault<Reservation>("Select * from Reservations where Id = @ResID", new { ResID = selectedID });


            if (reservation != null)
            {
                txtFname.Text = reservation.FirstName;
                txtLname.Text = reservation.LastName;
                txtYear.Text = reservation.BirthDay.Year.ToString();
                txtPhone.Text = reservation.PhoneNumber;
                txtEmail.Text = reservation.EmailAddress;
                txtAddress.Text = reservation.StreetAddress;
                txtAppNo_.Text = reservation.AptSuite;
                txtCity.Text = reservation.City;
                txtZipCode.Text = reservation.ZipCode;

                CboxDay.Text = reservation.BirthDay.Day.ToString();
                CboxMonth.Text = reservation.BirthDay.Month.ToString();
                CboxGender.Text = reservation.Gender;
                CboxState.Text = reservation.State;
                CboxGuestNumber.Text = reservation.NumberGuest.ToString().Trim();
                CboxRoomNumber.Text = reservation.RoomNumber.ToString().Trim();
                CboxRoomType.Text = reservation.RoomType.ToString().Trim();
                CboxFloor.Text = reservation.RoomFloor.ToString().Trim();

                dpStartdate.Text = reservation.ArrivalTime.ToString();
                dpEnddate.Text = reservation.LeavingTime.ToString();
            }
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int selectedID = int.Parse(CboxAllReservations.SelectedValue.ToString());

            //using dapper

            Reservation ? reservation = dapperDbConnection.QueryFirstOrDefault<Reservation>("Select * from Reservations where Id = @ResID", new { ResID = selectedID });
            if (reservation != null)
            {
                context.Reservations.Attach(reservation);

                FillReservationData(reservation);

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Reservation updated successfully" , "Updated reservation" , MessageBoxButton.OK , MessageBoxImage.Information);
                }
            }
        }
        public void FillReservationData(Reservation rsrv)
        {
            int totalFoodBill = 0;

            if (foodMenu != null)
            {
                totalFoodBill += foodMenu.BreakfastQ * 60 + foodMenu.LunchQ * 100 + foodMenu.DinnerQ * 200;

                rsrv.FoodBill = totalFoodBill;
                rsrv.Dinner = foodMenu.DinnerQ;
                rsrv.Lunch = foodMenu.LunchQ;
                rsrv.BreakFast = foodMenu.BreakfastQ;

                rsrv.Towel = foodMenu.Towels;
                rsrv.Cleaning = foodMenu.Cleaning;
                rsrv.SSurprise = foodMenu.Gifts;
            }
            

            rsrv.FirstName = txtFname.Text;
            rsrv.LastName = txtLname.Text;
            DateTime dateTime = new DateTime(Convert.ToInt32(txtYear.Text), Convert.ToInt32(CboxMonth.Text), Convert.ToInt32(CboxDay.Text));
            rsrv.BirthDay = dateTime.AddDays(1);
            rsrv.PhoneNumber = txtPhone.Text;
            rsrv.EmailAddress = txtEmail.Text;
            rsrv.StreetAddress = txtAddress.Text;
            rsrv.City = txtCity.Text;
            rsrv.AptSuite = txtAppNo_.Text;
            rsrv.ZipCode = txtZipCode.Text;

            rsrv.Gender = CboxGender.Text;
            rsrv.State = CboxState.Text;
            rsrv.NumberGuest = Convert.ToInt32(CboxGuestNumber.Text.Trim());
            rsrv.RoomNumber = CboxRoomNumber.Text.Trim();
            rsrv.RoomType = CboxRoomType.Text.Trim();
            rsrv.RoomFloor = CboxFloor.Text.Trim();

            rsrv.ArrivalTime = Convert.ToDateTime(dpStartdate.Text);
            rsrv.LeavingTime = Convert.ToDateTime(dpEnddate.Text);


            rsrv.TotalBill = (rsrv.FoodBill + (RoomPrices[rsrv.RoomType.Trim()] * (rsrv.LeavingTime - rsrv.ArrivalTime).TotalDays)) * 1.50;
            
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int selectedID = Convert.ToInt32(CboxAllReservations.SelectedValue);

            Reservation? reservation = dapperDbConnection.QueryFirstOrDefault<Reservation>("Select * from Reservation where Id = @ResID", new { ResID = selectedID });

            if (reservation != null)
            {
                context.Reservations.Remove(reservation);

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Reservation Deleted Successfully!", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                    CleanUp();
                }
            }
        }
        private void btnFullPayment_Click(object sender, RoutedEventArgs e)
        {
            FillReservationData(newReservation);
            Payment p = new Payment(newReservation);
            if (!p.IsActive)
            {
                p.ShowDialog();
            }
        }
    }
}
