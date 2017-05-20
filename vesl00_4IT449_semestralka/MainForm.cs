using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vesl00_4IT449_semestralka.Elements;
using vesl00_4IT449_semestralka.Exceptions;
using vesl00_4IT449_semestralka.Services;

namespace vesl00_4IT449_semestralka
{
    public partial class MainForm : Form
    {
        // Timer settings
        private int _refreshInterval = 16;
        private int _scoreRefreshInterval = 10000;

        // Game elements - ball, board, bricks
        private Ball _ball;
        private Board _board;
        private List<Brick> _bricks;

        // Misc utils
        private OverlapDetector _overlapDetector;
        private MessagesPainter _paint;

        // Game statuses
        private bool _paused = false;
        private bool _gameOver = false;
        private bool _gameStarted = false;
        private bool _levelDone = false;
        private bool _newLife = false;
        private int _level = 1;
        private int _score = 0;
        private int _lives = 5;

        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.MaximumSize = new Size(900, 650);
            this.MinimumSize = new Size(900, 650);
            mainTimer.Interval = _refreshInterval;
            scoreTimer.Interval = _scoreRefreshInterval;
            PrepareGame();
            _overlapDetector = new OverlapDetector();
            _paint = new MessagesPainter();
        }

        // Draw current status  into main window
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(_ball.GetBrush(), _ball.GetRectangle());
            e.Graphics.FillRectangle(_board.GetBrush(), _board.GetRectangle());
            _paint.CurrentScoreMessage(e, _level, _score, _lives);

            foreach (Brick brick in _bricks)
            {
                e.Graphics.FillRectangle(brick.GetBrush(), brick.GetRectangle());
            }

            if (!_gameStarted)
            {
                _paint.WelcomeMessage(e);
            }
            else if (_paused)
            {
                mainTimer.Stop();
                scoreTimer.Stop();
                _paint.PauseMessage(e);
            }
            else if (_gameOver)
            {
                mainTimer.Stop();
                scoreTimer.Stop();
                _paint.GameOverMessage(e);
            }
            else if (_levelDone)
            {
                mainTimer.Stop();
                scoreTimer.Stop();
                _paint.LevelDoneMessage(e);
            }
            else if (_newLife)
            {
                mainTimer.Stop();
                scoreTimer.Stop();
                _paint.NewLifeMessage(e);
            }
        }

        // Update game status - move ball, check borders, etc.
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (_overlapDetector.BallHitsBoard(_ball, _board))
            {
                _ball.UpdateDirectionAfterHit();
            }

            for (int i = _bricks.Count - 1; i >= 0; i--)
            {
                if (_overlapDetector.BallHitsBrick(_ball, _bricks[i]))
                {
                    _ball.UpdateDirectionAfterHit();
                    _bricks.RemoveAt(i);
                    _score += 10;
                }
            }

            if (_bricks.Count == 0)
            {
                _levelDone = true;
            }

            try
            {
                _ball.Move();
            }
            catch (GameOverException)
            {
                _lives--;

                if (_lives == 0)
                {
                    _gameOver = true;
                }
                else
                {
                    _newLife = true;
                }
            }
            
            Invalidate();
        }

        // Key pressed - move board or pause/resume game
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && !_paused)
            {
                _board.MoveRight();
            }
            else if (e.KeyCode == Keys.Left && !_paused)
            {
                _board.MoveLeft();
            } 
            else if (e.KeyCode == Keys.Space && !_gameStarted)
            {
                _paused = false;
                _gameStarted = true;
                mainTimer.Start();
                scoreTimer.Start();
            }
            else if (e.KeyCode == Keys.Space && _paused)
            {
                _paused = false;
                mainTimer.Start();
                scoreTimer.Start();
            }
            else if (e.KeyCode == Keys.Space && _levelDone)
            {
                _level++;
                PrepareGame();
                _levelDone = false;
                mainTimer.Start();
                scoreTimer.Start();
            }
            else if (e.KeyCode == Keys.Space && _newLife)
            {
                _ball = new Ball(Width, Height);
                _board = new Board(Width, Height);
                _newLife = false;
                mainTimer.Start();
                scoreTimer.Start();
            }
            else if (e.KeyCode == Keys.Space)
            {
                _paused = true;
            }
        }

        private void PrepareGame()
        {
            _ball = new Ball(Width, Height);
            _board = new Board(Width, Height);
            _bricks = BricksGenerator.Generate(_level, Width, Height);
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            _score--;
        }
    }
}
