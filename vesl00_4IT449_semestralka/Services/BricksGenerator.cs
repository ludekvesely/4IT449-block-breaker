using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vesl00_4IT449_semestralka.Elements;

namespace vesl00_4IT449_semestralka.Services
{
    // Generate bricks for game
    class BricksGenerator
    {
        // Generate bricks for first (entry) level of game
        public static List<Brick> FirstLevel(int ScreenWidth, int ScreenHeight)
        {
            List<Brick> bricks = new List<Brick>();
            int bricksPerRow = 10;
            int brickWidth = ((ScreenWidth - 3 * Brick.Margin) / bricksPerRow) - Brick.Margin;
            int firstRowY = 50;
            int rows = 2;

            for (int y = firstRowY; y < firstRowY + rows * (Brick.Height + Brick.Margin); y += (Brick.Height + Brick.Margin))
            {
                for (int x = 0; x < bricksPerRow; x++)
                {
                    bricks.Add(
                        new Brick(
                            x * brickWidth + (x * Brick.Margin) + Brick.Margin,
                            y,
                            brickWidth,
                            ScreenWidth,
                            ScreenHeight
                        )
                    );
                }
            }

            return bricks;
        }
    }
}
