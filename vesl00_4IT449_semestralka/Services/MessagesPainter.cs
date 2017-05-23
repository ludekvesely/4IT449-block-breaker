using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vesl00_4IT449_semestralka.DataObjects;

namespace vesl00_4IT449_semestralka.Services
{
    // Paint messages to main window
    class MessagesPainter
    {
        Font _fontTitle;
        Font _fontSubtitle;
        Font _fontScore;
        StringFormat _stringFormat;

        public MessagesPainter()
        {
            _fontTitle = new Font("Microsoft Sans Serif", 33, FontStyle.Bold);
            _fontSubtitle = new Font("Microsoft Sans Serif", 23);
            _fontScore = new Font("Microsoft Sans Serif", 20);
            _stringFormat = new StringFormat();
            _stringFormat.Alignment = StringAlignment.Center;
            _stringFormat.LineAlignment = StringAlignment.Center;
        }

        // Paint welcome screen
        public void WelcomeMessage(PaintEventArgs e)
        {
            DrawString(e, "Welcome to BLOCK BREAKER!", 140);
            DrawString(e, "Move board with left and right arrow", 270, false);
            DrawString(e, "Press SPACE to start game", 330, false);
        }

        // Paint paused game
        public void PauseMessage(PaintEventArgs e)
        {
            DrawString(e, "Paused", 180);
            DrawString(e, "Press space to continue", 310, false);
        }

        // Paint game over
        public void GameOverMessage(PaintEventArgs e)
        {
            DrawString(e, "Game Over!", 180);
            DrawString(e, "Enter your name and press ENTER:                                .", 310, false);
        }

        // Paint level done
        public void LevelDoneMessage(PaintEventArgs e)
        {
            DrawString(e, "Level done!", 180);
            DrawString(e, "Press space for next level", 310, false);
        }

        // Paint ball lost
        public void NewLifeMessage(PaintEventArgs e)
        {
            DrawString(e, "Ooops!", 180);
            DrawString(e, "Press space to continue", 310, false);
        }

        // Paint current score to top of the window
        public void CurrentScoreMessage(PaintEventArgs e, int level, int score, int lives)
        {
            string text = String.Concat("Level: ", level);
            Rectangle rect = new Rectangle(0, 0, 900, 50);
            e.Graphics.DrawString(text, _fontScore, Brushes.LightSteelBlue, rect, _stringFormat);

            string text2 = String.Concat("Score: ", score);
            Rectangle rect2 = new Rectangle(0, 0, 300, 50);
            e.Graphics.DrawString(text2, _fontScore, Brushes.LightSteelBlue, rect2, _stringFormat);

            string text3 = String.Concat("Lives: ", lives);
            Rectangle rect3 = new Rectangle(600, 0, 300, 50);
            e.Graphics.DrawString(text3, _fontScore, Brushes.LightSteelBlue, rect3, _stringFormat);
        }

        // Paint highscore
        public void Highscores(PaintEventArgs e, List<HighscoreDO> highscores)
        {
            DrawString(e, "Highscore", 5);
        }

        // Paint earned bonus
        public void BonusMessage(PaintEventArgs e, string Message)
        {
            DrawString(e, Message, 250, false);
        }

        // Paint string to form
        private void DrawString(PaintEventArgs e, string text, int top, bool title = true)
        {
            Rectangle rect = new Rectangle(0, top, 900, 150);
            e.Graphics.DrawString(text, title ? _fontTitle : _fontSubtitle, Brushes.LavenderBlush, rect, _stringFormat);
        }
    }
}
