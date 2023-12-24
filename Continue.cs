using Game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game
{
    public partial class Continue : Form
    {
        public Continue()
        {
            InitializeComponent();

        }
        
        private void Continue_load(object sender, EventArgs e)
        {
            playersListView.View = View.Details;
            playersListView.FullRowSelect = true;
            playersListView.Columns.Add("NICK", playersListView.Width);

            MainMenu menu = MainMenu.GetInstance;
            foreach (Player player in menu.players)
            {
                ListViewItem item = new ListViewItem(player.Nick);
                playersListView.Items.Add(item);
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu menu = MainMenu.GetInstance;
            menu.Show();
            this.Hide();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
           

            if (playersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Must select player", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedNick = playersListView.SelectedItems[0].SubItems[0].Text;

                MainMenu menu = MainMenu.GetInstance;
                Player found = menu.players.FirstOrDefault(p => p.Nick.Equals(selectedNick));

                Gameplay gameplay = new Gameplay(found);
                gameplay.Show();
                this.Hide();
            }
        }
    }
}
