using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;
using WinFormsApp1.COntext;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Contextpubs?.Dispose();
        }

        private void GridTitles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        pubsContext Contextpubs = new pubsContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            Contextpubs.Titles.Load();
            //Contextpubs.Publishers.Load();

            //var titles = (from t in Contextpubs.Titles
            //              where t.TitleId.Length > 0
            //              select t).ToList();

            //the query will not work until we use command that change defered excution to immediate excution
            //GridTitles.DataSource = new BindingList<Title>(titles);

            GridTitles.DataSource = Contextpubs.Titles.Local.ToBindingList();

            var Publishers = (from p in Contextpubs.Publishers
                              select p).ToList();

            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.HeaderText = "Publisher";
            col.DataSource = (Publishers);
            col.DisplayMember = "PubName";
            col.ValueMember = "PubId";
            // bind publisher name of publisher by pub id of title tables
            col.DataPropertyName = "PubId";
            //Bind its Value Member with Grid Data Source [ColName]
            GridTitles.Columns.Add(col);
            // hide the column
            GridTitles.Columns["PubId"].Visible = false;
            GridTitles.Columns["Pub"].Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contextpubs.SaveChanges();
        }
    }
}