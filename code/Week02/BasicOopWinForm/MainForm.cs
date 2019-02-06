using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicOopWinForm
{
    public partial class MainForm : Form
    {
        private Panel RedBox;

        private int NumberOfBoxes = 5;
        private int BoxWidth  = 20;
        private int BoxHeight = 20;
        private int BoxMargin = 10;

        public MainForm()
        {
            InitializeComponent();

            for(int i=0; i<this.NumberOfBoxes; i++)
            {
                Panel box  = new Panel();
                box.Width  = this.BoxWidth;
                box.Height = this.BoxHeight;
                box.Left   = i * (this.BoxWidth + this.BoxMargin);
                box.Top    = 20;
                box.BackColor = Color.Red;
                box.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(box);
                box.Click += Box_Click;
            }
        }

        private void Box_Click(object sender, EventArgs e)
        {
            Panel clickedBox = (Panel)sender;

            Random random = new Random();

            int width  = clickedBox.Width  + 1;
            int height = clickedBox.Height + 1;
            this.ChangeSize(clickedBox, width, height);

            int left = clickedBox.Left + 1;
            int top  = clickedBox.Top  + 1;
            ChangePosition(clickedBox, left, top);
        }

        private void ChangeSize(Panel box, int width, int height)
        {
            box.Width  = width;
            box.Height = height;
        }
        private void ChangePosition(Panel box, int left, int top)
        {
            box.Left = left;
            box.Top  = top;
        }
    }
}
