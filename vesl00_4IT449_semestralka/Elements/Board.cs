using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vesl00_4IT449_semestralka.Elements
{
    // Board controlled by player
    class Board : BaseElement
    {
        private int _width = 100;
        private int _height = 20;
        private int _moveStepSize = 14;

        public Board(int ScreenWidth, int ScreenHeight)
        {
            _rectangle = new Rectangle((ScreenWidth / 2) - (_width / 2), ScreenHeight - 80, _width, _height);
            _brush = Brushes.Gray;
            _screenWidth = ScreenWidth;
            _screenHeight = ScreenHeight;
        }

        public void MoveLeft()
        {
            if (_rectangle.X > 0)
            {
                _rectangle.X -= _moveStepSize;
            }
        }

        public void MoveRight()
        {
            if ((_rectangle.X + _width + _height) < _screenWidth)
            {
                _rectangle.X += _moveStepSize;
            }
        }
    }
}
