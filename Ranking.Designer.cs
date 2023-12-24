namespace Game
{
    partial class Ranking
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
            this.playersListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // titleList
            // 
            this.titleList.AutoSize = true;
            this.titleList.BackColor = System.Drawing.Color.Transparent;
            this.titleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleList.Location = new System.Drawing.Point(531, 52);
            this.titleList.Name = "titleList";
            this.titleList.Size = new System.Drawing.Size(148, 32);
            this.titleList.TabIndex = 14;
            this.titleList.Text = "RANKING";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(450, 590);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(335, 74);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // playersListView
            // 
            this.playersListView.BackColor = System.Drawing.Color.White;
            this.playersListView.BackgroundImage = global::Game.Properties.Resources.blur;
            this.playersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playersListView.ForeColor = System.Drawing.Color.White;
            this.playersListView.FullRowSelect = true;
            this.playersListView.GridLines = true;
            this.playersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.playersListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.playersListView.Location = new System.Drawing.Point(66, 129);
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(1143, 431);
            this.playersListView.TabIndex = 16;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.blur;
            this.ClientSize = new System.Drawing.Size(1291, 720);
            this.Controls.Add(this.playersListView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1291, 720);
            this.Name = "Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleList;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView playersListView;
    }
}