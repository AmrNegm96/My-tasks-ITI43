namespace WinFormsApp1
{
    partial class frmProductsDetailedView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrdID = new System.Windows.Forms.Label();
            this.txtPrdName = new System.Windows.Forms.TextBox();
            this.numUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnitInStock = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.NewSupplierName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeSupplier = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExcute = new System.Windows.Forms.Button();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.lstPrds = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrdID
            // 
            this.lblPrdID.AutoSize = true;
            this.lblPrdID.Location = new System.Drawing.Point(6, 46);
            this.lblPrdID.Name = "lblPrdID";
            this.lblPrdID.Size = new System.Drawing.Size(46, 20);
            this.lblPrdID.TabIndex = 3;
            this.lblPrdID.Text = "PrdID";
            // 
            // txtPrdName
            // 
            this.txtPrdName.Location = new System.Drawing.Point(104, 66);
            this.txtPrdName.Name = "txtPrdName";
            this.txtPrdName.Size = new System.Drawing.Size(150, 27);
            this.txtPrdName.TabIndex = 4;
            // 
            // numUnitInStock
            // 
            this.numUnitInStock.Location = new System.Drawing.Point(104, 104);
            this.numUnitInStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUnitInStock.Name = "numUnitInStock";
            this.numUnitInStock.Size = new System.Drawing.Size(150, 27);
            this.numUnitInStock.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Prd Name";
            // 
            // lblUnitInStock
            // 
            this.lblUnitInStock.AutoSize = true;
            this.lblUnitInStock.Location = new System.Drawing.Point(6, 106);
            this.lblUnitInStock.Name = "lblUnitInStock";
            this.lblUnitInStock.Size = new System.Drawing.Size(92, 20);
            this.lblUnitInStock.TabIndex = 7;
            this.lblUnitInStock.Text = "Unit In Stock";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(364, 360);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(364, 395);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(464, 395);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(94, 29);
            this.btnlast.TabIndex = 10;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(264, 360);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(94, 29);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 20;
            this.lstSuppliers.Location = new System.Drawing.Point(6, 169);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(186, 284);
            this.lstSuppliers.TabIndex = 12;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(104, 134);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(81, 20);
            this.lblSupplier.TabIndex = 13;
            this.lblSupplier.Text = "Supplier id";
            // 
            // NewSupplierName
            // 
            this.NewSupplierName.AutoSize = true;
            this.NewSupplierName.Location = new System.Drawing.Point(364, 169);
            this.NewSupplierName.Name = "NewSupplierName";
            this.NewSupplierName.Size = new System.Drawing.Size(102, 20);
            this.NewSupplierName.TabIndex = 14;
            this.NewSupplierName.Text = "supplierName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Supplier ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "New supplier name";
            // 
            // btnChangeSupplier
            // 
            this.btnChangeSupplier.Location = new System.Drawing.Point(198, 215);
            this.btnChangeSupplier.Name = "btnChangeSupplier";
            this.btnChangeSupplier.Size = new System.Drawing.Size(171, 29);
            this.btnChangeSupplier.TabIndex = 17;
            this.btnChangeSupplier.Text = "Change supplier name";
            this.btnChangeSupplier.UseVisualStyleBackColor = true;
            this.btnChangeSupplier.Click += new System.EventHandler(this.btnChangeSupplier_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(463, 45);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(94, 29);
            this.btnExcute.TabIndex = 2;
            this.btnExcute.Text = "Excute";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(463, 12);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(125, 27);
            this.txtNewPrice.TabIndex = 1;
            // 
            // lstPrds
            // 
            this.lstPrds.FormattingEnabled = true;
            this.lstPrds.ItemHeight = 20;
            this.lstPrds.Location = new System.Drawing.Point(605, 12);
            this.lstPrds.Name = "lstPrds";
            this.lstPrds.Size = new System.Drawing.Size(183, 444);
            this.lstPrds.TabIndex = 0;
            this.lstPrds.SelectedIndexChanged += new System.EventHandler(this.lstPrds_SelectedIndexChanged);
            // 
            // frmProductsDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangeSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewSupplierName);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lstSuppliers);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblUnitInStock);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.numUnitInStock);
            this.Controls.Add(this.txtPrdName);
            this.Controls.Add(this.lblPrdID);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.lstPrds);
            this.Name = "frmProductsDetailedView";
            this.Text = "frmProductsDetailedView";
            this.Load += new System.EventHandler(this.frmProductsDetailedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnitInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblPrdID;
        private TextBox txtPrdName;
        private NumericUpDown numUnitInStock;
        private Label lblName;
        private Label lblUnitInStock;
        private Button btnPrev;
        private Button btnNext;
        private Button btnlast;
        private Button btnFirst;
        private ListBox lstSuppliers;
        private Label lblSupplier;
        private Label NewSupplierName;
        private Label label2;
        private Label label1;
        private Button btnChangeSupplier;
        private Button btnSave;
        private Button btnExcute;
        private TextBox txtNewPrice;
        private ListBox lstPrds;
    }
}