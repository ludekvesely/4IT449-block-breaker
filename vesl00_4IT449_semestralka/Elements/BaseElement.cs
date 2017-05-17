using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vesl00_4IT449_semestralka.Elements
{
    // Base element contains common properties and methods for ball, board and bricks
    abstract class BaseElement
    {
        protected Rectangle _rectangle;
        protected Brush _brush;
        protected int _screenWidth;
        protected int _screenHeight;

        public Brush GetBrush()
        {
            return _brush;
        }

        public Rectangle GetRectangle()
        {
            return _rectangle;
        }

        public int LeftBorder()
        {
            return _rectangle.X;
        }

        public int RightBorder()
        {
            return _rectangle.X + _rectangle.Width;
        }

        public int TopBorder()
        {
            return _rectangle.Y;
        }

        public int BottomBorder()
        {
            return _rectangle.Y + _rectangle.Height;
        }
    }
}
