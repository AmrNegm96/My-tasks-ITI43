using HotelManagementSystem.HotelContext;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {

        Context context;
        public LoginPage()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            context = new Context();
            context.Logins.Load();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Password.ToString();

            if(userName==string.Empty || passWord==string.Empty || !checkLoginData(userName, passWord))
            {
                MessageBox.Show("please enter right logins", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private bool checkLoginData(string username, string password)
        {
            foreach(var item in context.Logins)
            {
                if(item.UserName==username && item.Password == password)
                {
                    if(item.IsAdmin)
                    {
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    else
                    {
                        Kitchen kitchen = new Kitchen();
                        kitchen.Show();
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
