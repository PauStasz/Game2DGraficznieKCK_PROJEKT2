namespace Game
{
    partial class Settings
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
            this.titleList = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.modeGame = new System.Windows.Forms.Label();
            this.easyModeGameButton = new System.Windows.Forms.Button();
            this.normalModeGameButton = new System.Windows.Forms.Button();
            this.hardModeGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleList
            // 
            this.titleList.AutoSize = true;
            this.titleList.BackColor = System.Drawing.Color.Transparent;
            this.titleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleList.Location = new System.Drawing.Point(521, 50);
            this.titleList.Name = "titleList";
            this.titleList.Size = new System.Drawing.Size(162, 32);
            this.titleList.TabIndex = 15;
            this.titleList.Text = "SETTINGS";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(434, 597);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(335, 74);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // modeGame
            // 
            this.modeGame.AutoSize = true;
            this.modeGame.BackColor = System.Drawing.Color.Transparent;
            this.modeGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modeGame.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modeGame.ForeColor = System.Drawing.Color.White;
            this.modeGame.Location = new System.Drawing.Point(532, 125);
            this.modeGame.Name = "modeGame";
            this.modeGame.Size = new System.Drawing.Size(140, 27);
            this.modeGame.TabIndex = 17;
            this.modeGame.Text = "MODE GAME";
            // 
            // easyModeGameButton
            // 
            this.easyModeGameButton.BackColor = System.Drawing.Color.Transparent;
            this.easyModeGameButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.easyModeGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.easyModeGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.easyModeGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.easyModeGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.easyModeGameButton.Location = new System.Drawing.Point(434, 178);
            this.easyModeGameButton.Name = "easyModeGameButton";
            this.easyModeGameButton.Size = new System.Drawing.Size(335, 74);
            this.easyModeGameButton.TabIndex = 18;
            this.easyModeGameButton.Text = "EASY";
            this.easyModeGameButton.UseVisualStyleBackColor = false;
            this.easyModeGameButton.Click += new System.EventHandler(this.easyModeGameButton_Click);
            // 
            // normalModeGameButton
            // 
            this.normalModeGameButton.BackColor = System.Drawing.Color.Transparent;
            this.normalModeGameButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.normalModeGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.normalModeGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.normalModeGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.normalModeGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.normalModeGameButton.Location = new System.Drawing.Point(434, 274);
            this.normalModeGameButton.Name = "normalModeGameButton";
            this.normalModeGameButton.Size = new System.Drawing.Size(335, 74);
            this.normalModeGameButton.TabIndex = 19;
            this.normalModeGameButton.Text = "NORMAL";
            this.normalModeGameButton.UseVisualStyleBackColor = false;
            this.normalModeGameButton.Click += new System.EventHandler(this.normalModeGameButton_Click);
            // 
            // hardModeGameButton
            // 
            this.hardModeGameButton.BackColor = System.Drawing.Color.Transparent;
            this.hardModeGameButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.hardModeGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hardModeGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hardModeGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hardModeGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hardModeGameButton.Location = new System.Drawing.Point(434, 366);
            this.hardModeGameButton.Name = "hardModeGameButton";
            this.hardModeGameButton.Size = new System.Drawing.Size(335, 74);
            this.hardModeGameButton.TabIndex = 20;
            this.hardModeGameButton.Text = "HARD";
            this.hardModeGameButton.UseVisualStyleBackColor = false;
            this.hardModeGameButton.Click += new System.EventHandler(this.hardModeGameButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.blur;
            this.ClientSize = new System.Drawing.Size(1291, 720);
            this.Controls.Add(this.hardModeGameButton);
            this.Controls.Add(this.normalModeGameButton);
            this.Controls.Add(this.easyModeGameButton);
            this.Controls.Add(this.modeGame);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1291, 720);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleList;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label modeGame;
        private System.Windows.Forms.Button easyModeGameButton;
        private System.Windows.Forms.Button normalModeGameButton;
        private System.Windows.Forms.Button hardModeGameButton;
    }
}