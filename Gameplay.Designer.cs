namespace Game
{
    partial class Gameplay
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
            this.nickLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.timeLeft = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.enemyBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startGame = new System.Windows.Forms.Label();
            this.startGameTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.Font = new System.Drawing.Font("Goudy Stout", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nickLabel.Location = new System.Drawing.Point(18, 11);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(255, 27);
            this.nickLabel.TabIndex = 1;
            this.nickLabel.Text = "NickPlayer";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pointsLabel.Location = new System.Drawing.Point(28, 38);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(67, 20);
            this.pointsLabel.TabIndex = 3;
            this.pointsLabel.Text = "POINTS";
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerBox.Location = new System.Drawing.Point(546, 572);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(101, 112);
            this.playerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerBox.TabIndex = 6;
            this.playerBox.TabStop = false;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.healthyLabel);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.timeLeft);
            this.panel.Controls.Add(this.nickLabel);
            this.panel.Controls.Add(this.pointsLabel);
            this.panel.Controls.Add(this.levelLabel);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1254, 94);
            this.panel.TabIndex = 11;
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLeft.Location = new System.Drawing.Point(1068, 18);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(90, 20);
            this.timeLeft.TabIndex = 4;
            this.timeLeft.Text = "TIME LEFT";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.levelLabel.Location = new System.Drawing.Point(28, 58);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(60, 20);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "LEVEL";
            // 
            // enemyBox
            // 
            this.enemyBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyBox.Location = new System.Drawing.Point(546, 122);
            this.enemyBox.Name = "enemyBox";
            this.enemyBox.Size = new System.Drawing.Size(181, 158);
            this.enemyBox.TabIndex = 10;
            this.enemyBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_TickAsync);
            // 
            // startGame
            // 
            this.startGame.AutoSize = true;
            this.startGame.BackColor = System.Drawing.Color.Transparent;
            this.startGame.Font = new System.Drawing.Font("Goudy Stout", 20F);
            this.startGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startGame.Location = new System.Drawing.Point(366, 378);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(511, 55);
            this.startGame.TabIndex = 12;
            this.startGame.Text = "START GAME";
            // 
            // startGameTimer
            // 
            this.startGameTimer.AutoSize = true;
            this.startGameTimer.BackColor = System.Drawing.Color.Transparent;
            this.startGameTimer.Font = new System.Drawing.Font("Goudy Stout", 15F);
            this.startGameTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startGameTimer.Location = new System.Drawing.Point(560, 433);
            this.startGameTimer.Name = "startGameTimer";
            this.startGameTimer.Size = new System.Drawing.Size(0, 41);
            this.startGameTimer.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(647, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(651, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // healthyLabel
            // 
            this.healthyLabel.AutoSize = true;
            this.healthyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.healthyLabel.Location = new System.Drawing.Point(1068, 48);
            this.healthyLabel.Name = "healthyLabel";
            this.healthyLabel.Size = new System.Drawing.Size(99, 20);
            this.healthyLabel.TabIndex = 5;
            this.healthyLabel.Text = "healthyLabel";
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Game.Properties.Resources.Starfield_03_1024x10241;
            this.ClientSize = new System.Drawing.Size(1291, 723);
            this.Controls.Add(this.startGameTimer);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.enemyBox);
            this.Controls.Add(this.playerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1291, 720);
            this.Name = "Gameplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.gameplay_loadAsync);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox enemyBox;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label startGame;
        private System.Windows.Forms.Label startGameTimer;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label healthyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}