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

namespace WinFormsApp1
{
    public partial class frmProductsDetailedView : Form
    {
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDA;
        DataTable DtPrds;
        SqlCommand sqlCmdUpdatedPrice;

        SqlCommand getSuppliersCmd;
        SqlDataAdapter SqlDataAdapterSuppliers;
        DataTable DtSuppliers;

        SqlCommand updateProductCmd;
        public frmProductsDetailedView()
        {
            InitializeComponent();
        }

        private void frmProductsDetailedView_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection("Data Source=DESKTOP-KMNQ6J7;initial catalog=Northwind;Integrated Security=true;Encrypt=false");
            sqlCmd = new SqlCommand("SelectAllproducts", sqlCn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlDA = new SqlDataAdapter(sqlCmd); //sqlDataAdapter takes the select command from me
            DtPrds = new DataTable(); // you can give it the name of table if you will work in dataset
            SqlCommandBuilder cmdB = new SqlCommandBuilder(sqlDA);

            sqlDA.Fill(DtPrds);

            /// complex data binding  (2 way binding)
            lstPrds.DataSource = DtPrds;
            lstPrds.DisplayMember = "ProductName";
            lstPrds.ValueMember = "ProductID";

            sqlCmdUpdatedPrice = new SqlCommand();
            sqlCmdUpdatedPrice.CommandText = "UPDATE Products SET UnitPrice = @UnitPrice WHERE  (ProductID = @ProductID)";
            sqlCmdUpdatedPrice.Connection = sqlCn;
            sqlCmdUpdatedPrice.Parameters.Add("@UnitPrice", SqlDbType.Money);
            sqlCmdUpdatedPrice.Parameters.Add("@ProductID", SqlDbType.Int);

            ///Supplier list
            getSuppliersCmd= new SqlCommand("select SupplierID , CompanyName from suppliers", sqlCn);
            SqlDataAdapterSuppliers = new SqlDataAdapter(getSuppliersCmd);
            DtSuppliers = new DataTable();
            SqlDataAdapterSuppliers.Fill(DtSuppliers);

            lstSuppliers.DataSource= DtSuppliers;
            lstSuppliers.DisplayMember = "CompanyName";
            lstSuppliers.ValueMember = "SupplierID";

            /// simple data binding

            /// 2 way binding and next and prev functions
            BindingSource PrdbindingSource = new BindingSource(DtPrds, "");

            lblPrdID.DataBindings.Add("Text", PrdbindingSource, "ProductID");
            txtPrdName.DataBindings.Add("Text", PrdbindingSource, "ProductName");
            numUnitInStock.DataBindings.Add("Value", PrdbindingSource, "UnitsInStock");

            lblSupplier.DataBindings.Add("Text", PrdbindingSource, "SupplierID");

            updateProductCmd = new SqlCommand("update Products set SupplierID = @SuppID where ProductID = @PrdID", sqlCn);
            updateProductCmd.Parameters.Add("@SuppID", SqlDbType.Int);
            updateProductCmd.Parameters.Add("@PrdID", SqlDbType.Int);

            BindingSource SuppBindingSrc = new BindingSource(DtSuppliers, "" );

            NewSupplierName.DataBindings.Add("Text", SuppBindingSrc, "SupplierID");


            btnNext.Click += (sender, e) => PrdbindingSource.MoveNext();
            btnPrev.Click += (sender, e) => PrdbindingSource.MovePrevious();
            btnFirst.Click += (sender, e) => PrdbindingSource.MoveFirst();
            btnlast.Click += (sender, e) => PrdbindingSource.MoveLast();

            BindingNavigator bindNav = new BindingNavigator(PrdbindingSource);
            bindNav.Location = new Point(Top, 0);
            this.Controls.Add(bindNav);

        }

        private void lstPrds_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when select item from list the window text be its id
            this.Text = lstPrds.SelectedValue.ToString();
            //selected index , selected items (object)
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNewPrice.Text, out decimal PrdPrice) && lstPrds.SelectedItems.Count > 0)
            {
                sqlCmdUpdatedPrice.Parameters["@UnitPrice"].Value = PrdPrice;
                sqlCmdUpdatedPrice.Parameters["@ProductID"].Value = lstPrds.SelectedValue;

                sqlCn.Open();

                if (sqlCmdUpdatedPrice.ExecuteNonQuery() > 0)
                {
                    this.Text = "Successfull";
                }
                else
                {
                    this.Text = "Error";
                }

                sqlCn.Close();
            }
        }

        private void btnChangeSupplier_Click(object sender, EventArgs e)
        {
            if (lstPrds.SelectedItems.Count > 0 && lstSuppliers.SelectedItems.Count>0)
            {
                updateProductCmd.Parameters["@SuppID"].Value = NewSupplierName.Text;
                updateProductCmd.Parameters["@PrdID"].Value = lblPrdID.Text;

                sqlCn.Open();

                if (updateProductCmd.ExecuteNonQuery() > 0)
                {
                    this.Text = "Successfull";
                }
                else
                {
                    this.Text = "Error";
                }

                sqlCn.Close();
            }
        }

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewSupplierName.Text = lstSuppliers.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlDA.Update(DtPrds);
        }
    }
}
