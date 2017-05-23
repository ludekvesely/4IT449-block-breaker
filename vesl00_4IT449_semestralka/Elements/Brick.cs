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
        private int _lives;
        private bool _fasterBall;
        private bool _widerBoard;

        public Brick(int X, int Y, int Width, int ScreenWidth, int ScreenHeight, int Lives = 1, bool Faster = false, bool Wider = false)
        {
            _rectangle = new Rectangle(X, Y, Width, Height);
            _screenWidth = ScreenWidth;
            _screenHeight = ScreenHeight;
            _lives = Lives;
            _fasterBall = Faster;
            _widerBoard = Wider;

            if (Lives > 1)
            {
                _brush = Brushes.Maroon;
            }
            else if (Faster)
            {
                _brush = Brushes.GreenYellow;
            }
            else if (Wider)
            {
                _brush = Brushes.PeachPuff;
            }
            else
            {
                _brush = Brushes.Firebrick;
            }
        }

        public void Hit()
        {
            if (_lives == 2)
            {
                _brush = Brushes.Firebrick;
            }

            _lives--;
        }

        public bool ShouldBeRemoved()
        {
            return (_lives < 1);
        }

        public bool MakesBallFaster()
        {
            return _fasterBall;
        }

        public bool MakesBoardWider()
        {
            return _widerBoard;
        }
    }
}
