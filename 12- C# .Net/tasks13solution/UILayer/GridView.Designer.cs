namespace UILayer
{
    partial class GridView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdViewTitles = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTitles)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewTitles
            // 
            this.grdViewTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewTitles.Location = new System.Drawing.Point(0, 28);
            this.grdViewTitles.Name = "grdViewTitles";
            this.grdViewTitles.RowHeadersWidth = 51;
            this.grdViewTitles.RowTemplate.Height = 29;
            this.grdViewTitles.Size = new System.Drawing.Size(800, 422);
            this.grdViewTitles.TabIndex = 0;
            this.grdViewTitles.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdViewTitles_UserAddedRow);
            this.grdViewTitles.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdViewTitles_UserDeletedRow);
            this.grdViewTitles.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grdViewTitles_UserDeletingRow);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.commandToolStripMenuItem.Text = "Command";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdViewTitles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GridView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTitles)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdViewTitles;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}