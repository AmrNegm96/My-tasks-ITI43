using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection();
            //exception of trust (certificate is must) we will add encrypt
            //sqlCn.ConnectionString = @"Data Source=DESKTOP-KMNQ6J7;initial catalog=Northwind;Integrated Security=true;Encrypt=false";
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;
            //TrusServerCertificate=true    instead of Encrypt=false
            sqlCn.StateChange += (sender, e) => this.Text = $"state was {e.OriginalState} , current is {e.CurrentState}";
           // this.Text = $"Branch id is {ConfigurationManager.AppSettings["BranchID"]}";
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;
            sqlCmd.CommandType = CommandType.Text; // default (you can change it to stored procedure)
            //sqlCmd.CommandText = "select count(*) from products";
            sqlCmd.CommandText = "select * from products";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(sqlCn.State == ConnectionState.Closed)
            {
                sqlCn.Open(); // open pipe line with data base (connection pooling)
         
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(sqlCn.State == ConnectionState.Open)
            {
                sqlCn.Close();  // close the pipe line it will not remove the object 
                                // because it takes big place of memory GC put it in her pocket until another open it get it faster 
            }
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            if(sqlCn.State == ConnectionState.Closed)
            {

                //// Connected  sql command
                ///
                sqlCn.Open();

                //this.Text = sqlCmd.ExecuteScalar()?.ToString()??"-1";   /// return single cell only
              
                SqlDataReader datareaderObj =  sqlCmd.ExecuteReader();

                while (datareaderObj.Read())
                {
                    // this is not binding binding is with only 1 line not line by line
                    // data reader doesnt support biniding 
                    // data reader is read only can not set value by it

                    this.LstProductsName.Items.Add(datareaderObj.GetString("ProductName"));
                }

                //LstProductsName.DataSource = datareaderObj;  //exception

                sqlCn.Close();
            }
        }
    }
}