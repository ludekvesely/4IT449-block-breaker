using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vesl00_4IT449_semestralka.Elements;

namespace vesl00_4IT449_semestralka.Services
{
    // Service that detects that ball overlaps board or brick
    class OverlapDetector
    {
        public bool BallHitsBoard(Ball Ball, Board Board)
        {
            return (Ball.BottomBorder() >= Board.TopBorder() && (Ball.LeftBorder() + 20) >= Board.LeftBorder() && (Ball.RightBorder() - 20) <= Board.RightBorder());
        }

        public bool BallHitsBrick(Ball Ball, Brick Brick)
        {
            return (Ball.BottomBorder() >= Brick.TopBorder() && Ball.TopBorder() <= Brick.BottomBorder() && (Ball.LeftBorder() + 20) >= Brick.LeftBorder() && (Ball.RightBorder() - 20) <= Brick.RightBorder());
        }
    }
}
