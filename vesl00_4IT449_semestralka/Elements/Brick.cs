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
        private bool _liveUp;
        private bool _liveDown;
        private bool _bonus;

        public Brick(
            int X, 
            int Y, 
            int Width, 
            int ScreenWidth, 
            int ScreenHeight, 
            int Lives = 1, 
            bool Faster = false, 
            bool Wider = false,
            bool LiveUp = false,
            bool LiveDown = false,
            bool Bonus = false
        ) {
            _rectangle = new Rectangle(X, Y, Width, Height);
            _screenWidth = ScreenWidth;
            _screenHeight = ScreenHeight;
            _lives = Lives;
            _fasterBall = Faster;
            _widerBoard = Wider;
            _liveUp = LiveUp;
            _liveDown = LiveDown;
            _bonus = Bonus;

            if (Lives > 1)
            {
                _brush = Brushes.Maroon;
            }
            else if (Faster)
            {
                _brush = Brushes.LightGray;
            }
            else if (Wider)
            {
                _brush = Brushes.Gray;
            }
            else if (LiveUp)
            {
                _brush = Brushes.Pink;
            }
            else if (LiveDown)
            {
                _brush = Brushes.Cyan;
            }
            else if (Bonus)
            {
                _brush = Brushes.Gold;
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

        public int GetLivesChange()
        {
            if (_liveUp)
            {
                return 1;
            }
            else if (_liveDown)
            {
                return -1;
            }

            return 0;
        }

        public bool AddsBonus()
        {
            return _bonus;
        }
    }
}
