using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu menu = MainMenu.GetInstance;
            menu.Show();
            this.Hide();
        }

        private void easyModeGameButton_Click(object sender, EventArgs e)
        {
            MainMenu menu = MainMenu.GetInstance;
            menu.ModeGame = 0;
            MessageBox.Show("Mode game was changed to easy.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void normalModeGameButton_Click(object sender, EventArgs e)
        {
            MainMenu menu = MainMenu.GetInstance;
            menu.ModeGame = 1;
            MessageBox.Show("Mode game was changed to normal.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hardModeGameButton_Click(object sender, EventArgs e)
        {
            MainMenu menu = MainMenu.GetInstance;
            menu.ModeGame = 2;
            MessageBox.Show("Mode game was changed to hard.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
