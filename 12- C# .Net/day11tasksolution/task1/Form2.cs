using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Point> circleList = new List<Point>();
        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics grfx = this.CreateGraphics();

            if(e.Button == MouseButtons.Left )
            {
                grfx.DrawEllipse(Pens.Red, e.X - 15, e.Y - 15, 30, 30);
            }
        }
    }
}
