using Game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu menu = MainMenu.GetInstance;
            menu.Show();
            this.Hide();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            playersListView.View = View.Details;
            playersListView.Columns.Add("RANK", 190);
            playersListView.Columns.Add("NICK", 190);
            playersListView.Columns.Add("TOTAL POINTS", 190);
            playersListView.Columns.Add("LEVEL", 190);


            MainMenu menu = MainMenu.GetInstance;
            int rank = 1;

            List<Player> ranking = menu.players;

            ranking.Sort((player1, player2) => player1.CurrentPoints.CompareTo(player2.CurrentPoints));
            ranking.Reverse();

            foreach (Player player in ranking)
            {
                ListViewItem item = new ListViewItem(rank.ToString());
                rank++;
                item.SubItems.Add(player.Nick.ToString());
                item.SubItems.Add(player.CurrentPoints.ToString());
                item.SubItems.Add(player.Level.ToString());
                playersListView.Items.Add(item);
            }
            
        }
    }
}
