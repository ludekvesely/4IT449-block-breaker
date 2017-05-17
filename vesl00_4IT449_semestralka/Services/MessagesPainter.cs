﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vesl00_4IT449_semestralka.Services
{
    // Paint messages to main window
    class MessagesPainter
    {
        Font _fontTitle;
        Font _fontSubtitle;
        StringFormat _stringFormat;

        public MessagesPainter()
        {
            _fontTitle = new Font("Microsoft Sans Serif", 33, FontStyle.Bold);
            _fontSubtitle = new Font("Microsoft Sans Serif", 23);
            _stringFormat = new StringFormat();
            _stringFormat.Alignment = StringAlignment.Center;
            _stringFormat.LineAlignment = StringAlignment.Center;
        }

        public void WelcomeMessage(PaintEventArgs e)
        {
            DrawString(e, "Welcome to BLOCK BREAKER!", 140);
            DrawString(e, "Move board with left and right arrow", 270, false);
            DrawString(e, "Press SPACE to start game", 330, false);
        }

        public void PauseMessage(PaintEventArgs e)
        {
            DrawString(e, "Paused", 180);
            DrawString(e, "Press space to continue", 310, false);
        }

        public void GameOverMessage(PaintEventArgs e)
        {
            DrawString(e, "Game Over!", 180);
            DrawString(e, "Enter your name:", 310, false);
        }

        private void DrawString(PaintEventArgs e, string text, int top, bool title = true)
        {
            Rectangle rect = new Rectangle(0, top, 900, 150);
            e.Graphics.DrawString(text, title ? _fontTitle : _fontSubtitle, Brushes.LavenderBlush, rect, _stringFormat);
        }
    }
}
