namespace Game
{
    partial class CreatePlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNickBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.playerIconBox = new System.Windows.Forms.PictureBox();
            this.createButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerIconBox)).BeginInit();
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
            this.backButton.Location = new System.Drawing.Point(71, 566);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(335, 74);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(537, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "INPUT YOUR NICK";
            // 
            // inputNickBox
            // 
            this.inputNickBox.BackColor = System.Drawing.Color.White;
            this.inputNickBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputNickBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.inputNickBox.Location = new System.Drawing.Point(509, 177);
            this.inputNickBox.Margin = new System.Windows.Forms.Padding(9, 9, 3, 3);
            this.inputNickBox.MinimumSize = new System.Drawing.Size(335, 70);
            this.inputNickBox.Multiline = true;
            this.inputNickBox.Name = "inputNickBox";
            this.inputNickBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputNickBox.Size = new System.Drawing.Size(335, 75);
            this.inputNickBox.TabIndex = 6;
            this.inputNickBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNickBox.TextChanged += new System.EventHandler(this.inputNickBox_TextChanged);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextButton.Location = new System.Drawing.Point(509, 288);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(335, 74);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // playerIconBox
            // 
            this.playerIconBox.BackColor = System.Drawing.Color.Transparent;
            this.playerIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playerIconBox.Location = new System.Drawing.Point(125, 150);
            this.playerIconBox.Name = "playerIconBox";
            this.playerIconBox.Size = new System.Drawing.Size(343, 347);
            this.playerIconBox.TabIndex = 9;
            this.playerIconBox.TabStop = false;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Transparent;
            this.createButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.createButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createButton.Location = new System.Drawing.Point(886, 566);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(335, 74);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "CREATE AND PLAY";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.BackgroundImage = global::Game.Properties.Resources.transparent_halfblack1;
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previousButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previousButton.Location = new System.Drawing.Point(509, 400);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(335, 74);
            this.previousButton.TabIndex = 11;
            this.previousButton.Text = "PREVIOUS";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // CreatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Game.Properties.Resources.blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 720);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.playerIconBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.inputNickBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1291, 720);
            this.Name = "CreatePlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePlayer";
            this.Load += new System.EventHandler(this.createPlayer_load);
            ((System.ComponentModel.ISupportInitialize)(this.playerIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNickBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox playerIconBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button previousButton;
    }
}