using System.Drawing;

namespace ClassAndObject.classes
{
    public class SmartBox : Box
    {
        public Color _Color { get; set; }
        public int _X { get; set; }
        public int _Y { get; set; }

        public SmartBox(int width, int height, Color color)
        {
            this._Color  = color;
            this._Width  = width;
            this._Height = height;

            this._Body.Width     = width;
            this._Body.Height    = height;
            this._Body.BackColor = color;
        }

        public void SetPositionX(int x)
        {
            this._X = x;
            this._Body.Left = x;
        }
        public void SetPositionY(int y)
        {
            this._Y = y;
            this._Body.Top = y;
        }
        public void SetPosition(int x, int y)
        {
            this.SetPositionX(x);
            this.SetPositionY(y);
        }
        public int GetPositionX(int x)
        {
            return this._X;
        }
        public int GetPositionY(int y)
        {
            return this._Y;
        }
    }
}
