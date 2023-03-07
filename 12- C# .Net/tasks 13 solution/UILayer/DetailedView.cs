using BusinessLogicLayer.Entity;
using BusinessLogicLayer.EntityList;
using BusinessLogicLayer.EntityManager;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace UILayer
{
    public partial class DetailedView : Form
    {
        public DetailedView()
        {
            InitializeComponent();
        }

        TitleList tl;
        TitleManager titleManager;
        publisherList pl;
        
        BindingNavigator nav;
        
        private void DetailedView_Load(object sender, EventArgs e)
        {
            //publisher Data ComboBox
            
            pl = new publisherList();
            pl = publisherManager.getPublishersNames();
            publisherComboBox.DataSource = new BindingList<Publisher>(pl);
            publisherComboBox.DisplayMember = "pub_name";
            publisherComboBox.ValueMember = "pub_id";

            //Titles Data Binding
            tl = new TitleList();
            tl = TitleManager.SelectAllTitles();
            BindingSource bindingSourceTitles = new BindingSource();
            bindingSourceTitles.DataSource = tl;
            txttitleID.DataBindings.Add("Text", bindingSourceTitles, "Title_id");
            txtTitle.DataBindings.Add("Text", bindingSourceTitles, "Title");
            txtNotes.DataBindings.Add("Text", bindingSourceTitles, "Notes");
            txtType.DataBindings.Add("Text", bindingSourceTitles, "Type");
            txtPrice.DataBindings.Add("Text", bindingSourceTitles, "Price");
            txtAdvance.DataBindings.Add("Text", bindingSourceTitles, "Advance");
            txtRoyalty.DataBindings.Add("Text", bindingSourceTitles, "Royalty");
            txtSales.DataBindings.Add("Text", bindingSourceTitles, "Ytd_sales");
            txtDatetime.DataBindings.Add("Text", bindingSourceTitles, "Pubdate");
            state.DataBindings.Add("Text", bindingSourceTitles, "State");
            publisherComboBox.DataBindings.Add("SelectedValue", bindingSourceTitles, "Pub_id");

           

            nav = new BindingNavigator(bindingSourceTitles);
            this.Controls.Add(nav);

            bindingSourceTitles.AddingNew += (sender, e) => e.NewObject = new titles() { State = EntityState.Added}; 
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TitleManager.DoActions(tl);
           
            //commit changes
            
            //reset all entity state to unchanged
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            TitleManager.DeleteTitle(this.txttitleID.Text);
        }
    }
}
