using Game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainMenu : Form
    {
        private static MainMenu instance = null;
        private Database db;
        public readonly SoundPlayer musicPlayer = new SoundPlayer(Properties.Resources.menu);

        public List<Player> players { get; set; } 
        public int ModeGame { get; set; } = 1;
        public static MainMenu GetInstance => instance ?? (instance = new MainMenu());
        private MainMenu()
        { 
            InitializeComponent();
            db = new Database("DatabasePlayers.json");
        }

        private void menu_load(object sender, EventArgs e)
        { 
            

            List<Player> getPlayers = db.DeserializeFromFile();

            if (getPlayers == null || getPlayers.Count <= 0)
            {
                
                players = new List<Player>() { new Player("Anna", Properties.Resources.Nairan___Battlecruiser___Base), new Player("Hania", Properties.Resources.Nairan___Battlecruiser___Base) };
            }
            else
                players = getPlayers;

            musicPlayer.Load();
            musicPlayer.PlayLooping();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            CreatePlayer createPlayer = new CreatePlayer();
            createPlayer.Show();
            this.Hide();
            
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            musicPlayer.Stop();
            musicPlayer.Dispose();
            db.SerializeToFile(players);
            Application.Exit();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Continue @continue = new Continue();
            @continue.Show();
            this.Hide();
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking();
            ranking.Show();
            this.Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }


    }
}
