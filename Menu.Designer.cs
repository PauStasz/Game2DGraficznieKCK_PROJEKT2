namespace Game
{
    partial class MainMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.rankingButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titleGameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::Game.Properties.Resources.HeroCard2;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rankingButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.continueButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.quitButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.newGameButton, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(100, 220, 100, 250);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 720);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.settingsButton.Location = new System.Drawing.Point(103, 420);
            this.settingsButton.MinimumSize = new System.Drawing.Size(264, 63);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(264, 63);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // rankingButton
            // 
            this.rankingButton.AutoSize = true;
            this.rankingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rankingButton.BackColor = System.Drawing.Color.Transparent;
            this.rankingButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.rankingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rankingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rankingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rankingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rankingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rankingButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rankingButton.Location = new System.Drawing.Point(103, 351);
            this.rankingButton.MinimumSize = new System.Drawing.Size(264, 63);
            this.rankingButton.Name = "rankingButton";
            this.rankingButton.Size = new System.Drawing.Size(264, 63);
            this.rankingButton.TabIndex = 7;
            this.rankingButton.Text = "RANKING";
            this.rankingButton.UseVisualStyleBackColor = false;
            this.rankingButton.Click += new System.EventHandler(this.rankingButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.AutoSize = true;
            this.continueButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.continueButton.BackColor = System.Drawing.Color.Transparent;
            this.continueButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.continueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.continueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.continueButton.Location = new System.Drawing.Point(103, 282);
            this.continueButton.MinimumSize = new System.Drawing.Size(264, 63);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(264, 63);
            this.continueButton.TabIndex = 6;
            this.continueButton.Text = "CONTINUE";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quitButton.Location = new System.Drawing.Point(103, 489);
            this.quitButton.MinimumSize = new System.Drawing.Size(264, 63);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(264, 63);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.AutoSize = true;
            this.newGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newGameButton.BackColor = System.Drawing.Color.Transparent;
            this.newGameButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.newGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newGameButton.Location = new System.Drawing.Point(103, 223);
            this.newGameButton.MinimumSize = new System.Drawing.Size(264, 53);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(264, 53);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "NEW GAME";
            this.newGameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // titleGameLabel
            // 
            this.titleGameLabel.AutoSize = true;
            this.titleGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleGameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleGameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleGameLabel.Font = new System.Drawing.Font("Old English Text MT", 82F, System.Drawing.FontStyle.Italic);
            this.titleGameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.titleGameLabel.Location = new System.Drawing.Point(470, 0);
            this.titleGameLabel.Name = "titleGameLabel";
            this.titleGameLabel.Padding = new System.Windows.Forms.Padding(120, 270, 0, 350);
            this.titleGameLabel.Size = new System.Drawing.Size(738, 815);
            this.titleGameLabel.TabIndex = 8;
            this.titleGameLabel.Text = "Shooter";
            this.titleGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Game.Properties.Resources.blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 720);
            this.ControlBox = false;
            this.Controls.Add(this.titleGameLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1291, 720);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.menu_load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label titleGameLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button rankingButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button newGameButton;
    }
}

