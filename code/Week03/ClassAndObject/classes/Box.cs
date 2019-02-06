using System.Windows.Forms;
namespace ClassAndObject.classes
{
    public class Box
    {
        public int _Width { get; set; }
        public int _Height { get; set; }
        public Panel _Body = new Panel();

        public Box()
        {
            _Width = _Height = 20;
            _Body.Width = _Body.Height = 20;
        }
        public Box(int size)
        {
            _Width = _Height = size;
            _Body.Width = _Body.Height = size;
        }
        public Box(int width, int height)
        {
            _Width = width;
            _Height = height;
            _Body.Width = _Width;
            _Body.Height = _Height;
        }
    }
}
