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
            return (Ball.BottomBorder() >= Board.TopBorder() && Ball.LeftBorder() >= Board.LeftBorder() && Ball.RightBorder() <= Board.RightBorder());
        }
    }
}
