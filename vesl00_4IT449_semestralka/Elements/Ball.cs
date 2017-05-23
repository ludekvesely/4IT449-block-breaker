using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vesl00_4IT449_semestralka.Exceptions;

namespace vesl00_4IT449_semestralka.Elements
{
    // Ball moving around main window
    class Ball : BaseElement
    {
        private const int _defaultStepSize = 4;
        private const int _fastStepSize = 7;
        private int _moveStepSize;
        private int _direction = 1;
        private int _size = 20;

        public Ball(int ScreenWidth, int ScreenHeight)
        {
            _rectangle = new Rectangle(ScreenWidth / 2 - _size / 2, ScreenHeight - 101, _size, _size);
            _brush = Brushes.LightGray;
            _screenWidth = ScreenWidth;
            _screenHeight = ScreenHeight;
            NormalSpeed();
        }

        public void FasterSpeed()
        {
            _moveStepSize = _fastStepSize;
        }

        public void NormalSpeed()
        {
            _moveStepSize = _defaultStepSize;
        }

        public void Move()
        {
            if (_direction == 1)
            {
                _rectangle.X += _moveStepSize;
                _rectangle.Y -= _moveStepSize;
            }
            else if (_direction == 2)
            {
                _rectangle.X -= _moveStepSize;
                _rectangle.Y -= _moveStepSize;
            }
            else if (_direction == 3)
            {
                _rectangle.X -= _moveStepSize;
                _rectangle.Y += _moveStepSize;
            }
            else
            {
                _rectangle.X += _moveStepSize;
                _rectangle.Y += _moveStepSize;
            }

            UpdateDirection();
        }

        private void UpdateDirection()
        {
            if (_direction == 1)
            {
                if (IsBehindRightBorder())
                {
                    _direction = 2;
                }
                else if (IsBehindTopBorder())
                {
                    _direction = 4;
                }
            }
            else if (_direction == 2)
            {
                if (IsBehindTopBorder())
                {
                    _direction = 3;
                }
                else if (IsBehindLeftBorder())
                {
                    _direction = 1;
                }
            }
            else if (_direction == 3)
            {
                if (IsBehindLeftBorder())
                {
                    _direction = 4;
                }
                else if (IsBehindBottomBorder())
                {
                    throw new GameOverException();
                }
            }
            else if (_direction == 4)
            {
                if (IsBehindRightBorder())
                {
                    _direction = 3;
                }
                else if (IsBehindBottomBorder())
                {
                    throw new GameOverException();
                }
            }
        }

        public void UpdateDirectionAfterHit()
        {
            if (_direction == 1)
            {
                _direction = 4;
            }
            else if (_direction == 2)
            {
                _direction = 3;
            }
            else if (_direction == 3)
            {
                _direction = 2;
            }
            else if (_direction == 4)
            {
                _direction = 1;
            }
        }

        private bool IsBehindRightBorder()
        {
            return (_rectangle.X >= (_screenWidth - (_rectangle.Width * 1.8)));
        }

        private bool IsBehindTopBorder()
        {
            return (_rectangle.Y <= 0);
        }

        private bool IsBehindLeftBorder()
        {
            return (_rectangle.X <= 0);
        }

        private bool IsBehindBottomBorder()
        {
            return (_rectangle.Y >= (_screenHeight - (_rectangle.Height * 3)));
        }
    }
}
