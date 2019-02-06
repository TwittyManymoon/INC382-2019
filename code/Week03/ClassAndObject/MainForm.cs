using ClassAndObject.classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace ClassAndObject
{
    public partial class MainForm : Form
    {
        private List<SmartBox> Boxes = new List<SmartBox>();
        public MainForm()
        {
            InitializeComponent();
            for(int i=0; i<50; i++)
            {
                SmartBox box = new SmartBox(5, 10, Color.Red);
                this.Controls.Add(box._Body);
                Boxes.Add(box);
            }
            Timer timer = new Timer();
            timer.Interval = 1000 / 60;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        double alpha = 0.0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Boxes.Count; i++)
            {
                int x = i * 8;
                int y = (int)(this.Height / 3 - Math.Sin(alpha + Math.PI *
                                        4 * i / Boxes.Count) * this.Height / 3.5);
                Boxes[i].SetPosition(x, y);
                alpha += Math.PI / 5000;
            }
        }
    }
}
