using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOopWinForm.classes
{

    public class Ball : Box
    {

        public int _Speed { get; set; }
        public int _WorldHeight { get; set; }
        public int _Direction { get; set; }

        //!! Constructor
        public Ball(int width, int height, Color color) 
            : base(width, height, color)
        {
            _Speed = 1; // Initial value
        }

        //!! Another Constructor
        public Ball(int width, int height, Color color, 
            int Speed, int WorldHeight)
           : base(width, height, color)
        {
            _Speed       = Speed; 
            _WorldHeight = WorldHeight;
            _Direction   = +1;
        }

        //!! When this method is called the ball will
        //!! fall/move down _Speed pixel(s).
        public void Update()
        {
            int y = this.GetPositionY();
            if(y > _WorldHeight)
            {
                _Direction *= -1;
            }

            this.SetPositionY(y + _Speed * _Direction);
        }
    }
}
