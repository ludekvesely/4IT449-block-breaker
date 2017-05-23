namespace vesl00_4IT449_semestralka
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.nickInput = new System.Windows.Forms.TextBox();
            this.highscoreList = new System.Windows.Forms.DataGridView();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingLabel = new System.Windows.Forms.Label();
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            this.bonusMessageTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.highscoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 10;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // scoreTimer
            // 
            this.scoreTimer.Interval = 10;
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimer_Tick);
            // 
            // nickInput
            // 
            this.nickInput.BackColor = System.Drawing.Color.Black;
            this.nickInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nickInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.nickInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nickInput.Location = new System.Drawing.Point(12, 12);
            this.nickInput.Name = "nickInput";
            this.nickInput.Size = new System.Drawing.Size(550, 61);
            this.nickInput.TabIndex = 0;
            this.nickInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nickInput_KeyDown);
            // 
            // highscoreList
            // 
            this.highscoreList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.highscoreList.AllowUserToAddRows = false;
            this.highscoreList.AllowUserToDeleteRows = false;
            this.highscoreList.AllowUserToResizeColumns = false;
            this.highscoreList.AllowUserToResizeRows = false;
            this.highscoreList.BackgroundColor = System.Drawing.Color.Black;
            this.highscoreList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highscoreList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.highscoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highscoreList.ColumnHeadersVisible = false;
            this.highscoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.highscoreList.DefaultCellStyle = dataGridViewCellStyle2;
            this.highscoreList.Location = new System.Drawing.Point(12, 80);
            this.highscoreList.Name = "highscoreList";
            this.highscoreList.ReadOnly = true;
            this.highscoreList.RowHeadersVisible = false;
            this.highscoreList.RowTemplate.Height = 31;
            this.highscoreList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.highscoreList.ShowCellErrors = false;
            this.highscoreList.ShowCellToolTips = false;
            this.highscoreList.ShowEditingIcon = false;
            this.highscoreList.ShowRowErrors = false;
            this.highscoreList.Size = new System.Drawing.Size(240, 150);
            this.highscoreList.TabIndex = 1;
            this.highscoreList.TabStop = false;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(98, 465);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(301, 77);
            this.buttonPlayAgain.TabIndex = 2;
            this.buttonPlayAgain.TabStop = false;
            this.buttonPlayAgain.Text = "Play again!";
            this.buttonPlayAgain.UseVisualStyleBackColor = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(438, 465);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(301, 77);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Nick";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 455;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Score";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // savingLabel
            // 
            this.savingLabel.AutoSize = true;
            this.savingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.savingLabel.Location = new System.Drawing.Point(322, 369);
            this.savingLabel.Name = "savingLabel";
            this.savingLabel.Size = new System.Drawing.Size(205, 54);
            this.savingLabel.TabIndex = 4;
            this.savingLabel.Text = "Saving...";
            // 
            // ballTimer
            // 
            this.ballTimer.Interval = 8000;
            this.ballTimer.Tick += new System.EventHandler(this.ballTimer_Tick);
            // 
            // bonusMessageTimer
            // 
            this.bonusMessageTimer.Interval = 3000;
            this.bonusMessageTimer.Tick += new System.EventHandler(this.bonusMessageTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(876, 586);
            this.Controls.Add(this.savingLabel);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.highscoreList);
            this.Controls.Add(this.nickInput);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLOCK BREAKER";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.highscoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.TextBox nickInput;
        private System.Windows.Forms.DataGridView highscoreList;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label savingLabel;
        private System.Windows.Forms.Timer ballTimer;
        private System.Windows.Forms.Timer bonusMessageTimer;
    }
}

