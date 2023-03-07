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
    public partial class form3 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand sqlCmdUpdatePrice;
        SqlCommand sqlCmdUpdateName;
        SqlCommand sqlCmdUpdateSupp;
        SqlCommand sqlCmdUpdateQPerUnit;
        SqlCommand sqlCmdUpdateUnitsInStock;
        SqlCommand sqlCmdUpdateUnitsOnOrder;
        SqlCommand sqlCmdUpdateReorderLevel;
        SqlCommand sqlCmdUpdateDiscontinued;
        SqlCommand sqlCmdUpdateCategoryID;


        public form3()
        {
            InitializeComponent();
        }

        private void form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.;initial Catalog=Northwind;Integrated Security=true;Encrypt=false";
            cmd = new SqlCommand("selectAllProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd2 = new();
            cmd2.CommandText = "Update Products SET UnitPrice=@UnitPrice WHERE (ProductID=@ProductID)";
            cmd2.Connection = conn;
            cmd2.Parameters.Add("@UnitPrice", SqlDbType.Money);
            cmd2.Parameters.Add("@ProductID", SqlDbType.Int);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);



             //Update price
            sqlCmdUpdatePrice = new SqlCommand();
            sqlCmdUpdatePrice.CommandText = "Update Products SET UnitPrice=@UnitPrice WHERE (ProductID=@ProductID)";
            sqlCmdUpdatePrice.Connection = conn;
            sqlCmdUpdatePrice.Parameters.Add("@UnitPrice", SqlDbType.Money);
            sqlCmdUpdatePrice.Parameters.Add("@ProductID", SqlDbType.Int);

           

            // Update name
            sqlCmdUpdateName = new SqlCommand();
            sqlCmdUpdateName.CommandText = "Update Products SET ProductName=@ProductName WHERE (ProductID=@ProductID)";
            sqlCmdUpdateName.Connection = conn;
            sqlCmdUpdateName.Parameters.Add("@ProductName", SqlDbType.NVarChar);
            sqlCmdUpdateName.Parameters.Add("@ProductID", SqlDbType.Int);
            

            // Update  supplier
            sqlCmdUpdateSupp = new SqlCommand();
            sqlCmdUpdateSupp.CommandText = "Update Products SET SupplierID=@SupplierID WHERE (ProductID=@ProductID)";
            sqlCmdUpdateSupp.Connection = conn;
            sqlCmdUpdateSupp.Parameters.Add("@SupplierID", SqlDbType.Int);
            sqlCmdUpdateSupp.Parameters.Add("@ProductID", SqlDbType.Int);
           

            // Update Quantity Per Unit
            sqlCmdUpdateQPerUnit = new SqlCommand();
            sqlCmdUpdateQPerUnit.CommandText = "Update Products SET QuantityPerUnit=@QuantityPerUnit WHERE (ProductID=@ProductID)";
            sqlCmdUpdateQPerUnit.Connection = conn;
            sqlCmdUpdateQPerUnit.Parameters.Add("@QuantityPerUnit", SqlDbType.NVarChar);
            sqlCmdUpdateQPerUnit.Parameters.Add("@ProductID", SqlDbType.Int);


            // Update Units In Stock
            sqlCmdUpdateUnitsInStock = new SqlCommand();
            sqlCmdUpdateUnitsInStock.CommandText = "Update Products SET UnitsInStock=@UnitsInStock WHERE (ProductID=@ProductID)";
            sqlCmdUpdateUnitsInStock.Connection = conn;
            sqlCmdUpdateUnitsInStock.Parameters.Add("@UnitsInStock", SqlDbType.SmallInt);
            sqlCmdUpdateUnitsInStock.Parameters.Add("@ProductID", SqlDbType.Int);
          

            // Update UnitsOnOrder
            sqlCmdUpdateUnitsOnOrder = new SqlCommand();
            sqlCmdUpdateUnitsOnOrder.CommandText = "Update Products SET UnitsOnOrder=@UnitsOnOrder WHERE (ProductID=@ProductID)";
            sqlCmdUpdateUnitsOnOrder.Connection = conn;
            sqlCmdUpdateUnitsOnOrder.Parameters.Add("@UnitsOnOrder", SqlDbType.SmallInt);
            sqlCmdUpdateUnitsOnOrder.Parameters.Add("@ProductID", SqlDbType.Int);
         

            // Update Reorder level
            sqlCmdUpdateReorderLevel = new SqlCommand();
            sqlCmdUpdateReorderLevel.CommandText = "Update Products SET ReorderLevel=@ReorderLevel WHERE (ProductID=@ProductID)";
            sqlCmdUpdateReorderLevel.Connection = conn;
            sqlCmdUpdateReorderLevel.Parameters.Add("@ReorderLevel", SqlDbType.SmallInt);
            sqlCmdUpdateReorderLevel.Parameters.Add("@ProductID", SqlDbType.Int);
            

            // Update Discontinued
            sqlCmdUpdateDiscontinued = new SqlCommand();
            sqlCmdUpdateDiscontinued.CommandText = "Update Products SET Discontinued=@Discontinued WHERE (ProductID=@ProductID)";
            sqlCmdUpdateDiscontinued.Connection = conn;
            sqlCmdUpdateDiscontinued.Parameters.Add("@Discontinued", SqlDbType.Bit);
            sqlCmdUpdateDiscontinued.Parameters.Add("@ProductID", SqlDbType.Int);
            

            // Update CategoryID
            sqlCmdUpdateCategoryID = new SqlCommand();
            sqlCmdUpdateCategoryID.CommandText = "Update Products SET CategoryID=@CategoryID WHERE (ProductID=@ProductID)";
            sqlCmdUpdateCategoryID.Connection = conn;
            sqlCmdUpdateCategoryID.Parameters.Add("@CategoryID", SqlDbType.Int);
            sqlCmdUpdateCategoryID.Parameters.Add("@ProductID", SqlDbType.Int);
           

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();

            BindingSource bindingSource = new BindingSource(dt, "");
            textBox1.DataBindings.Add("Text", bindingSource, "ProductID");
            textBox2.DataBindings.Add("Text", bindingSource, "ProductName");
            textBox3.DataBindings.Add("Text", bindingSource, "SupplierID");
            textBox4.DataBindings.Add("Text", bindingSource, "CategoryID");
            textBox5.DataBindings.Add("Text", bindingSource, "QuantityPerUnit");
            textBox6.DataBindings.Add("Text", bindingSource, "UnitPrice");
            textBox7.DataBindings.Add("Text", bindingSource, "UnitsInStock");
            BindingNavigator bindingNavigator = new BindingNavigator(bindingSource);
            this.Controls.Add(bindingNavigator);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            adapter.Update(dt);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            adapter.Update(dt);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Update price
            if (decimal.TryParse(textBox6.Text, out decimal PrdPrice))
            {
                sqlCmdUpdatePrice.Parameters["@UnitPrice"].Value = PrdPrice;
                sqlCmdUpdatePrice.Parameters["@ProductID"].Value = textBox1.Text;

                conn.Open();

                if (sqlCmdUpdatePrice.ExecuteNonQuery() > 0)
                    this.Text = "Done";
                else
                    this.Text = "Error";

                conn.Close();
            }
            //

            // Update name
            string prdName = textBox2.Text;
            sqlCmdUpdateName.Parameters["@ProductName"].Value = prdName;
            sqlCmdUpdateName.Parameters["@ProductID"].Value = textBox1.Text;

            conn.Open();

            if (sqlCmdUpdateName.ExecuteNonQuery() > 0)
                this.Text = "Done";
            else
                this.Text = "Error";

            conn.Close();

            //

            // Update supplier
            if (int.TryParse(textBox3.Text, out int PrdSupp))
            {
                sqlCmdUpdateSupp.Parameters["@SupplierID"].Value = PrdSupp;
                sqlCmdUpdateSupp.Parameters["@ProductID"].Value = textBox1.Text;

                conn.Open();

                if (sqlCmdUpdateSupp.ExecuteNonQuery() > 0)
                    this.Text = "Done";
                else
                    this.Text = "Error";

                conn.Close();
            }
            //

            // Update Category
            if (int.TryParse(textBox4.Text, out int PrdCategory))
            {
                sqlCmdUpdateCategoryID.Parameters["@CategoryID"].Value = PrdCategory;
                sqlCmdUpdateCategoryID.Parameters["@ProductID"].Value = textBox1.Text;

                conn.Open();

                if (sqlCmdUpdateCategoryID.ExecuteNonQuery() > 0)
                    this.Text = "Done";
                else
                    this.Text = "Error";

                conn.Close();
            }
            //

            // Update Quantity Per Unit
            string QPerUnit = textBox5.Text;
            sqlCmdUpdateQPerUnit.Parameters["@QuantityPerUnit"].Value = QPerUnit;
            sqlCmdUpdateQPerUnit.Parameters["@ProductID"].Value = textBox1.Text;

            conn.Open();

            if (sqlCmdUpdateQPerUnit.ExecuteNonQuery() > 0)
                this.Text = "Done";
            else
                this.Text = "Error";

            conn.Close();

            //

            // Update Units In Stock
            if (int.TryParse(textBox7.Text, out int UnitsInStk))
            {
                sqlCmdUpdateUnitsInStock.Parameters["@UnitsInStock"].Value = UnitsInStk;
                sqlCmdUpdateUnitsInStock.Parameters["@ProductID"].Value = textBox1.Text;

                conn.Open();

                if (sqlCmdUpdateUnitsInStock.ExecuteNonQuery() > 0)
                    this.Text = "Done";
                else
                    this.Text = "Error";

                conn.Close();
            }
            //

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ////
        }
    }
}
