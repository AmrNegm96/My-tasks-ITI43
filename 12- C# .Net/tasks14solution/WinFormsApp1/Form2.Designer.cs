namespace WinFormsApp1
{
    partial class Form2
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
            this.btndelete = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.Label();
            this.txtDatetime = new System.Windows.Forms.DateTimePicker();
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtRoyalty = new System.Windows.Forms.TextBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPublisherID = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txttitleID = new System.Windows.Forms.TextBox();
            this.lblpubdate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblRoyalty = new System.Windows.Forms.Label();
            this.lblAdvc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblpublisherID = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbltitleID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(694, 370);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 29);
            this.btndelete.TabIndex = 50;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(333, 17);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(50, 20);
            this.state.TabIndex = 49;
            this.state.Text = "label1";
            // 
            // txtDatetime
            // 
            this.txtDatetime.Location = new System.Drawing.Point(184, 353);
            this.txtDatetime.Name = "txtDatetime";
            this.txtDatetime.Size = new System.Drawing.Size(379, 27);
            this.txtDatetime.TabIndex = 48;
            // 
            // publisherComboBox
            // 
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Location = new System.Drawing.Point(184, 405);
            this.publisherComboBox.Name = "publisherComboBox";
            this.publisherComboBox.Size = new System.Drawing.Size(379, 28);
            this.publisherComboBox.TabIndex = 47;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(12, 405);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(69, 20);
            this.lblPublisher.TabIndex = 46;
            this.lblPublisher.Text = "Publisher";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(694, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(184, 320);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(379, 27);
            this.txtNotes.TabIndex = 44;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(184, 278);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(379, 27);
            this.txtSales.TabIndex = 43;
            // 
            // txtRoyalty
            // 
            this.txtRoyalty.Location = new System.Drawing.Point(184, 243);
            this.txtRoyalty.Name = "txtRoyalty";
            this.txtRoyalty.Size = new System.Drawing.Size(379, 27);
            this.txtRoyalty.TabIndex = 42;
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(184, 213);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(379, 27);
            this.txtAdvance.TabIndex = 41;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(184, 181);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(379, 27);
            this.txtPrice.TabIndex = 40;
            // 
            // txtPublisherID
            // 
            this.txtPublisherID.Location = new System.Drawing.Point(184, 144);
            this.txtPublisherID.Name = "txtPublisherID";
            this.txtPublisherID.Size = new System.Drawing.Size(379, 27);
            this.txtPublisherID.TabIndex = 39;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(184, 110);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(379, 27);
            this.txtType.TabIndex = 38;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(184, 74);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(379, 27);
            this.txtTitle.TabIndex = 37;
            // 
            // txttitleID
            // 
            this.txttitleID.Location = new System.Drawing.Point(184, 42);
            this.txttitleID.Name = "txttitleID";
            this.txttitleID.Size = new System.Drawing.Size(379, 27);
            this.txttitleID.TabIndex = 36;
            // 
            // lblpubdate
            // 
            this.lblpubdate.AutoSize = true;
            this.lblpubdate.Location = new System.Drawing.Point(12, 353);
            this.lblpubdate.Name = "lblpubdate";
            this.lblpubdate.Size = new System.Drawing.Size(109, 20);
            this.lblpubdate.TabIndex = 35;
            this.lblpubdate.Text = "date of publish";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 318);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(48, 20);
            this.lblNotes.TabIndex = 34;
            this.lblNotes.Text = "Notes";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(12, 278);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(43, 20);
            this.lblSales.TabIndex = 33;
            this.lblSales.Text = "Sales";
            // 
            // lblRoyalty
            // 
            this.lblRoyalty.AutoSize = true;
            this.lblRoyalty.Location = new System.Drawing.Point(12, 243);
            this.lblRoyalty.Name = "lblRoyalty";
            this.lblRoyalty.Size = new System.Drawing.Size(58, 20);
            this.lblRoyalty.TabIndex = 32;
            this.lblRoyalty.Text = "Royalty";
            // 
            // lblAdvc
            // 
            this.lblAdvc.AutoSize = true;
            this.lblAdvc.Location = new System.Drawing.Point(12, 213);
            this.lblAdvc.Name = "lblAdvc";
            this.lblAdvc.Size = new System.Drawing.Size(66, 20);
            this.lblAdvc.TabIndex = 31;
            this.lblAdvc.Text = "Advance";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 181);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 20);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "Price";
            // 
            // lblpublisherID
            // 
            this.lblpublisherID.AutoSize = true;
            this.lblpublisherID.Location = new System.Drawing.Point(12, 144);
            this.lblpublisherID.Name = "lblpublisherID";
            this.lblpublisherID.Size = new System.Drawing.Size(88, 20);
            this.lblpublisherID.TabIndex = 29;
            this.lblpublisherID.Text = "Publisher ID";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 110);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 20);
            this.lblType.TabIndex = 28;
            this.lblType.Text = "Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 74);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Title";
            // 
            // lbltitleID
            // 
            this.lbltitleID.AutoSize = true;
            this.lbltitleID.Location = new System.Drawing.Point(12, 42);
            this.lbltitleID.Name = "lbltitleID";
            this.lbltitleID.Size = new System.Drawing.Size(57, 20);
            this.lbltitleID.TabIndex = 26;
            this.lbltitleID.Text = "Title ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.state);
            this.Controls.Add(this.txtDatetime);
            this.Controls.Add(this.publisherComboBox);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.txtRoyalty);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPublisherID);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txttitleID);
            this.Controls.Add(this.lblpubdate);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblRoyalty);
            this.Controls.Add(this.lblAdvc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblpublisherID);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbltitleID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btndelete;
        private Label state;
        private DateTimePicker txtDatetime;
        private ComboBox publisherComboBox;
        private Label lblPublisher;
        private Button btnSave;
        private TextBox txtNotes;
        private TextBox txtSales;
        private TextBox txtRoyalty;
        private TextBox txtAdvance;
        private TextBox txtPrice;
        private TextBox txtPublisherID;
        private TextBox txtType;
        private TextBox txtTitle;
        private TextBox txttitleID;
        private Label lblpubdate;
        private Label lblNotes;
        private Label lblSales;
        private Label lblRoyalty;
        private Label lblAdvc;
        private Label lblPrice;
        private Label lblpublisherID;
        private Label lblType;
        private Label lblTitle;
        private Label lbltitleID;
    }
}