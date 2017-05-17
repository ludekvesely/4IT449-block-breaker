using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vesl00_4IT449_semestralka.Elements
{
    class Brick : BaseElement
    {
        public const int Height = 20;
        public const int Margin = 5;

        public Brick(int X, int Y, int Width, int ScreenWidth, int ScreenHeight)
        {
            _rectangle = new Rectangle(X, Y, Width, Height);
            _brush = Brushes.Firebrick;
            _screenWidth = ScreenWidth;
            _screenHeight = ScreenHeight;
        }
    }
}
