using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Diagnostics;
using System.Collections;

namespace WinFormsApp1
{
    public partial class FrmProductGridView : Form
    {
        public FrmProductGridView()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDA;
        DataTable DtPrds;

        SqlCommand sqlcmd2;
        SqlDataAdapter sqlDA2;
        DataTable Dtsupp;
        
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // disconnected mode as developer i dont have to manage the state of connection (open/close)
            // excute select command of sql data adapter
            // run select command and takes the return from DB fill the data table
            // open connection excute command  fill data table close connection 

            sqlDA.Fill(DtPrds);
            grdPrds.DataSource = DtPrds;
            sqlDA2.Fill(Dtsupp);

            DataGridViewComboBoxColumn combo1 = new DataGridViewComboBoxColumn();
            combo1.HeaderText = "Supplier";
            combo1.DataSource = Dtsupp;
            combo1.DisplayMember = "CompanyName";
            combo1.ValueMember = "SupplierID";
            combo1.DataPropertyName = "SupplierID";
            grdPrds.Columns.Add(combo1);


            //foreach (DataRow row in DtPrds.Rows)
            //{
            //    row.SetField(DtPrds.Columns.IndexOf("SupplierID"), 1);
            //}
            
            //SqlCommand getSUppliersNames = new();
            //getSUppliersNames.CommandText = "select SupplierID , CompanyName from Suppliers";
            //getSUppliersNames.Connection = sqlCn;

            //sqlDA2 = new SqlDataAdapter(getSUppliersNames);
            //DtSuppliers = new DataTable();

            //sqlDA2.Fill(DtSuppliers);

            //Dictionary<int, string> dictionary = new();

            //foreach (DataRow row in DtSuppliers.Rows)
            //{
            //    dictionary.Add(row.Field<int>(0), row.Field<string>(1));
            //}

            //DtPrds.Columns.Add("SupplierName", typeof(string));

            ////foreach (KeyValuePair<int, string> d in dictionary)
            ////{
            //    Debug.WriteLine(string.Format("Key = {0}, Value = {1}", d.Key, d.Value));
            //}

            //foreach (DataRow row in DtPrds.Rows)
            //{
            //    row.SetField(DtPrds.Columns.IndexOf("SupplierName"), dictionary[row.Field<int>(2)]);
            //}

            //DtPrds.Columns.Remove("SupplierID");


            //for (int rowIndex = 0; rowIndex < DtPrds.Rows.Count; rowIndex++)
            //{
            //    DtPrds.Rows[rowIndex][9] = dictionary[DtPrds.Rows[rowIndex][2]];
            //}

            /// complex data biniding (2 way binding bysama3 fel data table keda keda) (with only one line of code i will fill the grid)
           // in this moment we have local copy of table in the data table
            grdPrds.DataSource = DtPrds;
        }

        private void FrmProductGridView_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection("Data Source=DESKTOP-KMNQ6J7;initial catalog=Northwind;Integrated Security=true;Encrypt=false");
            // sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString);
            sqlCmd = new SqlCommand("select * from Products", sqlCn);

            sqlDA = new SqlDataAdapter(sqlCmd); //sqlDataAdapter takes the select command from me
            DtPrds= new DataTable(); // you can give it the name of table if you will work in dataset
        
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDA);
            sqlDA.InsertCommand = commandBuilder.GetInsertCommand();
            sqlDA.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlDA.DeleteCommand = commandBuilder.GetDeleteCommand();

            sqlcmd2 = new SqlCommand("select * from Suppliers", sqlCn);
            sqlDA2 = new SqlDataAdapter(sqlcmd2);
            Dtsupp = new DataTable();
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDA2);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (DataRow row in DtPrds.Rows)
            //{
            //    Debug.WriteLine(row.RowState);
            //}

            // open db connection , commit changes to db (insert , update , delete) close connection
            //if(sqlDA.DeleteCommand != null)
            //{

            //}
            //else
            //{
            //    this.Text = "you do not have authorization to delete records";
            //}
            grdPrds.EndEdit();

            try
            {
                sqlDA.Update(DtPrds);
                sqlDA2.Update(Dtsupp);
            }
            catch
            {
                MessageBox.Show("can not delete");
            }
            
           
        }
    }
}
