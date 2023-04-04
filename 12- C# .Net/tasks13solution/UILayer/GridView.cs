using BusinessLogicLayer.EntityList;
using BusinessLogicLayer.EntityManager;
using BusinessLogicLayer.Entity;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.ComponentModel;

namespace UILayer
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }

        TitleList tltLst;
        publisherList publist;
        private void GridView_Load(object sender, EventArgs e)
        {
            tltLst = TitleManager.SelectAllTitles();
            publist = publisherManager.SelectAllPublishers();

            grdViewTitles.DataSource =  new BindingList<titles> (tltLst);

            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.HeaderText = "Publisher";
            col.DataSource = new BindingList<Publisher>(publist);
            col.DisplayMember = "pub_name";
            col.ValueMember = "pub_id";

            // bind publisher name of publisher by pub id of title tables
            col.DataPropertyName = "pub_id";
            ///Bind its Value Member with Grid Data Source [ColName]
            grdViewTitles.Columns.Add(col);
            // can not be edited
            //sgrdViewTitles.Columns[0].ReadOnly = true;
            // hide the column
            grdViewTitles.Columns["pub_id"].Visible = false;



        }
        private void grdViewTitles_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string deletedID = tltLst.ElementAt(e.Row.Index).Title_id;
            TitleManager.DeleteTitle(deletedID).ToString();
            //tltLst.ElementAt(e.Row.Index).State = EntityState.Deleted;
        }
        private void grdViewTitles_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            tltLst.ElementAt(e.Row.Index-1).State = EntityState.Added;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdViewTitles.EndEdit();
            TitleManager.DoActions(tltLst);

            //if(titleid.text.length>0 && title.text.length>0)
            //{
            //   var status = TitleManager.UpdateTitleNamebyTitleID("1", "title");
            //    this.Text = $"{status}";
            //}
        }

        private void grdViewTitles_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //
        }

        

    }
}