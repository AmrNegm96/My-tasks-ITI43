using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using WinFormsApp1.COntext;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.DirectoryServices.ActiveDirectory;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        pubsContext Contextpubs = new pubsContext();
        BindingNavigator nav;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contextpubs.SaveChanges();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //var deleted = (from t in Contextpubs.Titles
            //              where Contextpubs.Entry(t).State==EntityState.Deleted
            //              select t).First();
            //Contextpubs.Titles.Remove(deleted);
            //Contextpubs.SaveChanges();
        }
        static int counter = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            Contextpubs.Titles.Load();
            //Contextpubs.Publishers.Load();

            var titlesList = Contextpubs.Titles.Local.ToBindingList();
            //var publishersList = Contextpubs.Publishers.Local.ToBindingList();

            var publishersList = (from p in Contextpubs.Publishers
                                  select p).ToList();

            publisherComboBox.DataSource = publishersList;
            publisherComboBox.DisplayMember = "PubName";
            publisherComboBox.ValueMember = "PubId";

            //var titlesList = (from t in Contextpubs.Titles
                              //where t.TitleId.Length > 0
                              //select t).ToList();

            //the query will not work until we use command that change defered excution to immediate excution
            BindingSource bindingSourceTitles = new BindingSource();
            bindingSourceTitles.DataSource = /*new BindingList<Title>*/ (titlesList);

            txttitleID.DataBindings.Add("Text", bindingSourceTitles, "TitleId");
            txtTitle.DataBindings.Add("Text", bindingSourceTitles, "Title1");
            publisherComboBox.DataBindings.Add("SelectedValue", bindingSourceTitles, "PubId");
            txtNotes.DataBindings.Add("Text", bindingSourceTitles, "Notes");
            txtType.DataBindings.Add("Text", bindingSourceTitles, "Type");
            txtPrice.DataBindings.Add("Text", bindingSourceTitles, "Price");
            txtAdvance.DataBindings.Add("Text", bindingSourceTitles, "Advance");
            txtRoyalty.DataBindings.Add("Text", bindingSourceTitles, "Royalty");
            txtSales.DataBindings.Add("Text", bindingSourceTitles, "YtdSales");
            txtDatetime.DataBindings.Add("Text", bindingSourceTitles, "Pubdate");

            bindingSourceTitles.AddingNew += (sender, e) => e.NewObject = new Title() { TitleId = $"{counter++}" , Pubdate= DateTime.Now };

            nav = new BindingNavigator(bindingSourceTitles);
            this.Controls.Add(nav);
        }
    }
}
