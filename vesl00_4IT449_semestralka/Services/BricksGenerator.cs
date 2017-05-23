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
        public static List<Brick> Generate(int level, int ScreenWidth, int ScreenHeight)
        {
            List<Brick> bricks = new List<Brick>();
            int bricksPerRow = 10;
            int brickWidth = ((ScreenWidth - 3 * Brick.Margin) / bricksPerRow) - Brick.Margin;
            int firstRowY = 50;
            int rows = Math.Min(1 + level, 7);

            int row = 1;

            for (int y = firstRowY; y < firstRowY + rows * (Brick.Height + Brick.Margin); y += (Brick.Height + Brick.Margin))
            {
                for (int x = 0; x < bricksPerRow; x++)
                {
                    bricks.Add(
                        new Brick(
                            x * brickWidth + (x * Brick.Margin) + Brick.Margin,
                            (row > 2) ? (y + 200) : y,
                            brickWidth,
                            ScreenWidth,
                            ScreenHeight,
                            (((bricks.Count() + level - 1) % 15) == 2) ? 2 : 1,
                            (((bricks.Count() + level - 1) % 30) == 8) ? true : false,
                            (((bricks.Count() + level - 1) % 30) == 14) ? true : false
                        )
                    );
                }

                row++;
            }

            return bricks;
        }
    }
}
