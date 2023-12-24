namespace Game
{
    partial class Continue
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
            this.backButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.playersListView = new System.Windows.Forms.ListView();
            this.titleList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(95, 545);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(335, 74);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playButton.Location = new System.Drawing.Point(890, 545);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(335, 74);
            this.playButton.TabIndex = 11;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playersListView
            // 
            this.playersListView.BackColor = System.Drawing.Color.White;
            this.playersListView.BackgroundImage = global::Game.Properties.Resources.blur;
            this.playersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playersListView.ForeColor = System.Drawing.Color.White;
            this.playersListView.FullRowSelect = true;
            this.playersListView.GridLines = true;
            this.playersListView.HideSelection = false;
            this.playersListView.HoverSelection = true;
            this.playersListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.playersListView.Location = new System.Drawing.Point(338, 126);
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(578, 364);
            this.playersListView.TabIndex = 12;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            // 
            // titleList
            // 
            this.titleList.AutoSize = true;
            this.titleList.BackColor = System.Drawing.Color.Transparent;
            this.titleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleList.Location = new System.Drawing.Point(535, 61);
            this.titleList.Name = "titleList";
            this.titleList.Size = new System.Drawing.Size(152, 32);
            this.titleList.TabIndex = 13;
            this.titleList.Text = "PLAYERS";
            // 
            // Continue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.blur;
            this.ClientSize = new System.Drawing.Size(1291, 720);
            this.Controls.Add(this.titleList);
            this.Controls.Add(this.playersListView);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1291, 720);
            this.Name = "Continue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Continue";
            this.Load += new System.EventHandler(this.Continue_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.Label titleList;
    }
}