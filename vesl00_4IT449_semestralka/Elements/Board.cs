﻿using System;
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
        private const int _width = 100;
        private const int _height = 20;
        private int _moveStepSize = 14;

        public Board(int ScreenWidth, int ScreenHeight)
        {
            _rectangle = new Rectangle((ScreenWidth / 2) - (_width / 2), ScreenHeight - 80, _width, _height);
            _brush = Brushes.Gray;
            _screenWidth = ScreenWidth;
            _screenHeight = ScreenHeight;
        }

        // Move board to left (check border)
        public void MoveLeft()
        {
            if (_rectangle.X > 0)
            {
                _rectangle.X -= _moveStepSize;
            }
        }

        // Move board to right (check border)
        public void MoveRight()
        {
            if ((_rectangle.X + _rectangle.Width + _height) < _screenWidth)
            {
                _rectangle.X += _moveStepSize;
            }
        }

        // Set default width of board
        public void DefaultWidth()
        {
            _rectangle.Width = _width;
        }

        // Make board wider
        public void Wider()
        {
            _rectangle.Width += 50;
        }
    }
}
