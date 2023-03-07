namespace MyForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            //this.Resize += (sender, e) => Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Font myFont = new Font(this.Font.FontFamily, 25);
            string myStr = "Hello World";
            var textDimensions = e.Graphics.MeasureString(myStr, myFont);
            Brush mybrush = new SolidBrush(Color.FromArgb(this.Height % 255, this.Width % 255, ((this.Height / 2) + (this.Width / 2)) % 255));
            var posX = this.ClientSize.Width - textDimensions.Width;
            var posY = this.ClientSize.Height - textDimensions.Height;
            e.Graphics.DrawString(myStr, myFont, mybrush, posX/2, posY/2);
            base.OnPaint(e);
        }
    }
}