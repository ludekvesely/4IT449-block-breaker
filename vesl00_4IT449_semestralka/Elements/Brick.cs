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
        protected int _lives;

        public Brick(int X, int Y, int Width, int ScreenWidth, int ScreenHeight, int Lives = 1)
        {
            _rectangle = new Rectangle(X, Y, Width, Height);
            _brush = (Lives > 1) ? Brushes.Maroon : Brushes.Firebrick;
            _screenWidth = ScreenWidth;
            _screenHeight = ScreenHeight;
            _lives = Lives;
        }

        public void Hit()
        {
            _lives--;
            
            if (_lives <= 1)
            {
                _brush = Brushes.Firebrick;
            }
        }

        public bool ShouldBeRemoved()
        {
            return (_lives < 1);
        }
    }
}
