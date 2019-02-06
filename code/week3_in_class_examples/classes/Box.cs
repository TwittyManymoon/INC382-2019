using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicOopWinForm.classes
{
    public class Box
    {
        public int   _Width { get; set; }
        public int   _Height { get; set; }

        private int   _X { get; set; }
        private int   _Y { get; set; }

        public Color _Color { get; set; }

        public Panel _Boby { get; set; }

        // "public" can access from other classes


        // Constructor
        public Box(int width, int height, Color color)
        {
            _Width  = width;
            _Height = height;
            _Color  = color;

            //!! Visualized component/object
            _Boby = new Panel();
            _Boby.Width     = _Width;
            _Boby.Height    = _Height;
            _Boby.BackColor = _Color;

        }

        // Method

        public void MoveTo(int x, int y)
        {
            _X = x;
            _Y = y;

            _Boby.Left = x;
            _Boby.Top  = y;
        }

        public void SetPositionX(int x)
        {
            _X = x;
            _Boby.Left = x;
        }
        public void SetPositionY(int y)
        {
            _Y = y;
            _Boby.Top = y;
        }

        public int GetPositionX()
        {
            return _X;
        }
        public int GetPositionY()
        {
            return _Y;
        }
    }
}
