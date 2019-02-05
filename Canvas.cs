using BasicOopWinForm.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOPFundamental
{
    public partial class Canvas : Form
    {
        Ball ball1, ball2, ball3;

        public Canvas()
        {
            InitializeComponent();

            //!! Create a box using the Box class
            //Box box1 = new Box(20, 30, Color.Red);

            //!! Add the box1._Body into the form
            //!! The default position/location of the
            //!! object is (0, 0), the top-left of the screen
            //Controls.Add(box1._Boby);


            //!! Change the location of the box to (100, 200
            //box1.MoveTo(100, 50);

            //!! Whay we not do this?
            //box1._X = 100;

            //box1.SetPositionX(999999);


            //MessageBox.Show( box1.GetPositionX().ToString() );


            /*
            int NB = 5;
            int boxWidth = 20;
            int boxHeight = 30;
            int boxMaginLeft = 50;
            int boxSpace = boxWidth + boxMaginLeft;
            int boxMaginTop = 20;
            Random r = new Random();
            for (int i=0; i<NB; i++)
            {
                Color color = Color.FromArgb(
                            r.Next(0, 256), r.Next(0, 256), 0);

                Box box = new Box(boxWidth, boxHeight, color);
                box.MoveTo(i * boxSpace + boxMaginLeft, boxMaginTop);
                Controls.Add(box._Boby);
            }
            */


            ball1 = new Ball(50, 50, Color.Red, 5, this.Height);
            Controls.Add(ball1._Boby);

            ball2 = new Ball(20, 50, Color.Lime, 3, this.Height);
            Controls.Add(ball2._Boby);

            ball3 = new Ball(50, 30, Color.Blue, 7, this.Height);
            Controls.Add(ball3._Boby);

            //!! Create a timer and used as ticker
            Timer timer = new Timer();
            timer.Interval = 1000 / 60;     // 60 fps
            timer.Tick += Timer_Tick;
            timer.Enabled = true;           // Start

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ball1.Update();
            ball2.Update();
            ball3.Update();
        }
    }
}
