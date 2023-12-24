using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Game.Models;

namespace Game
{
    public partial class CreatePlayer : Form
    {
        private int _currentIndexImage;
        private ImageList _playerIcons;
        private string _nickPlayer;
        public CreatePlayer()
        {
            InitializeComponent();

        }

        private void createPlayer_load(object sender, EventArgs e)
        {
            Bitmap image1 = Properties.Resources.Nairan___Battlecruiser___Base;
            Bitmap image2 = Properties.Resources.Nairan___Dreadnought___Base;
            _playerIcons = new ImageList();
            _playerIcons.ImageSize = new Size(140, 200);
            _playerIcons.ColorDepth = ColorDepth.Depth32Bit;
            _playerIcons.Images.Add(image1);
            _playerIcons.Images.Add(image2);


            _currentIndexImage = 0;

            Bitmap image = (Bitmap)_playerIcons.Images[_currentIndexImage];
            playerIconBox.Image = image;
            playerIconBox.BackgroundImageLayout = ImageLayout.Center;
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu menu = MainMenu.GetInstance;
            menu.Show();
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
            if(_currentIndexImage <= _playerIcons.Images.Count - 2)
            {
                _currentIndexImage++;
            }
            else
            {
                _currentIndexImage = 0;
            }

            ChangePictureInBox();
        }

        private void ChangePictureInBox()
        {
            Bitmap image = (Bitmap)_playerIcons.Images[_currentIndexImage];
            playerIconBox.Image = image;
            playerIconBox.BackgroundImageLayout = ImageLayout.Center;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if(_nickPlayer == null || _nickPlayer.Length == 0)
            {
                MessageBox.Show("Nick cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap iconPlayer = (Bitmap)_playerIcons.Images[_currentIndexImage];
                Player player = new Player(_nickPlayer, iconPlayer);
                MainMenu menu = MainMenu.GetInstance;
                menu.players.Add(player);
                Gameplay gameplay = new Gameplay(player);
                gameplay.Show();
                this.Hide();
            }
                
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (_currentIndexImage > 0)
            {
                _currentIndexImage--;
            }
            else
            {
                _currentIndexImage = _playerIcons.Images.Count - 1;
            }

            ChangePictureInBox();
        }

        private void inputNickBox_TextChanged(object sender, EventArgs e)
        {
            _nickPlayer = inputNickBox.Text;
        }


    }
}
