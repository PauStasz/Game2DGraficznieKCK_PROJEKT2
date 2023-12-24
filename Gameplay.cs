using Game.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Gameplay : Form
    {
        private Player _player;
        private Thread enemyThread;
        private Thread playerThread;
        private int gameTime;
        private int points;
        private int enemyShowTime;
        private int explosionShowTime;
        private int amountHealth = 3;
        private Random random;
        private KeyEventArgs keyPlayer = null;
        private readonly SoundPlayer musicLoading = new SoundPlayer(Properties.Resources.in_the_wreckage);
        private readonly SoundPlayer musicGameplay = new SoundPlayer(Properties.Resources.battle);
        public Gameplay()
        {
            InitializeComponent();
            
        }

        public Gameplay(Player player)
        {
            InitializeComponent(); 
            _player = player;
            
        }

        private async void gameplay_loadAsync(object sender, EventArgs e)
        {
            //get mode game
            MainMenu menu = MainMenu.GetInstance;

            menu.musicPlayer.Stop();
            menu.musicPlayer.Dispose();
            musicLoading.Load();
            musicLoading.PlayLooping();

            switch (menu.ModeGame)
            {
                case 0:
                    gameTime = 900;
                    points = 10;
                    enemyShowTime = 11500;
                    explosionShowTime = 300;
                    break;
                case 1:
                    gameTime = 600;
                    points = 5;
                    enemyShowTime = 5000;
                    explosionShowTime = 100;
                    break; 
                case 2:
                    gameTime = 300;
                    points = 1;
                    enemyShowTime = 4500;
                    explosionShowTime = 100;
                    break;
            }

            //set data for player
            nickLabel.Text = _player.Nick.ToUpper();
            healthyLabel.Text = "HEALTH ♡ ♡ ♡";

            //start for game
            await Task.Delay(3000);
            startGameTimer.Text = "IN 3S";
            playerBox.Visible = false;
            enemyBox.Visible = false;
            await Task.Delay(1000);
            startGameTimer.Text = "IN 2S";
            await Task.Delay(1000);
            startGameTimer.Text = "IN 1S";
            await Task.Delay(1000);
            startGameTimer.Text = "IN 0S";
            this.Controls.Remove(startGame);
            startGame.Dispose();
            this.Controls.Remove(startGameTimer);
            startGameTimer.Dispose();

            musicLoading.Stop();
            musicLoading.Dispose();
            musicGameplay.Load();
            musicGameplay.PlayLooping();

            //set player
            levelLabel.Text = "LEVEL " + _player.Level.ToString();
            pointsLabel.Text = "POINTS " + _player.CurrentPoints.ToString();
            playerBox.Visible = true;
            playerBox.Image = new Bitmap(_player.Icon, new Size(120, 130));
            playerBox.Location = new Point(playerBox.Location.X, 320);

            //set enemy
            enemyBox.Visible = true;
            enemyBox.Image = new Bitmap(Properties.Resources.Ship3, new Size(Properties.Resources.Ship3.Width, Properties.Resources.Ship3.Height));

            //set time
            timer.Interval = gameTime;
            

            //threads and timer
            timer.Start();
            enemyThread = new Thread(controlEnemyMovementAsync);
            enemyThread.Start();

            //end threads
            enemyThread.Join();

            //end gameplay

        }

        private async void timer_TickAsync(object sender, EventArgs e)
        {
            if (gameTime == 0 || amountHealth <= 0)
            {
                timer.Stop();
            }

            timeLeft.Text = "TIME LEFT " + gameTime.ToString() + "S";
            gameTime--;

            if (gameTime <= 0 || amountHealth <= 0)
            {

                playerThread.Join();

                this.Controls.Remove(enemyBox);
                enemyBox.Dispose();
                this.Controls.Remove(playerBox);
                playerBox.Dispose();

                Label result = new Label();
                result.Width = 800;
                result.Height = 300;
                this.Controls.Add(result);
                result.ForeColor = Color.White;
                result.BackColor = Color.Transparent;
                result.Font = new Font("Goudy Stout", 15);
                result.Text = "YOU SCORE " + _player.CurrentPoints.ToString() + " POINTS AND " + _player.Level.ToString() + " LEVEL SO FAR";
                result.Location = new Point(50, 200);
                await Task.Delay(10000);

                MainMenu menu = MainMenu.GetInstance;

                for(int i = 0; i < menu.players.Count; i++)
                    if (menu.players[i].Nick == _player.Nick)
                        menu.players[i] = _player;

                musicGameplay.Stop();
                musicGameplay.Dispose();

                menu.Show();
                this.Hide();
            }
        }


        private async void controlEnemyMovementAsync()
        {
            random = new Random();

            while (gameTime >= 0 && amountHealth > 0)
            {
                try
                {
                    BeginInvoke((Action)delegate
                    {
                        enemyBox.Location = new Point(random.Next(20, 680), 70);

                    });

                    int isShot = random.Next(0, 11);
                    if (isShot == 5|| isShot == 9)
                    {
                        BeginInvoke((Action)async delegate
                        {
                            PictureBox shootBox = new PictureBox();
                            this.Controls.Add(shootBox);
                            int x = enemyBox.Location.X;
                            int y = enemyBox.Location.Y;

                            shootBox.BackColor = Color.Transparent;
                            shootBox.Image = Properties.Resources.Fx_04_1;
                            shootBox.Location = new Point(x + 30, y + 80);

                            for (int i = 0; i < 40; i++)
                            {
                                await Task.Delay(1);

                                if (i == 4)
                                    shootBox.Image = Properties.Resources.Fx_04_2;
                                else if (i == 30)
                                {
                                    shootBox.Image = Properties.Resources.Fx_04_3;
                                    shootBox.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                                }


                                shootBox.Location = new Point(shootBox.Location.X, shootBox.Location.Y + 5);
                            }
                            
                            //check health
                            if(shootBox.Location.X >= playerBox.Location.X &&  shootBox.Location.X <= (playerBox.Location.X + shootBox.Width / 2))
                            {
                                amountHealth--;
                                string heart = new string('♡', amountHealth);
                                healthyLabel.Text = "HEALTH " + heart;
                            }

                            this.Controls.Remove(shootBox);
                            shootBox.Dispose();

                        });

                        
                    }

                    await Task.Delay(enemyShowTime);
                }
                catch(Exception)
                {

                }    
            }
        }

        private void control_KeyDown(object sender, KeyEventArgs e)
        {
            keyPlayer = e;
            playerThread = new Thread(movePlayer);
            playerThread.Start();
        }

        private void movePlayer()
        {
            if (keyPlayer != null)
                switch (keyPlayer.KeyCode)
                {
                    case Keys.Right:
                        playerBox_move(10, 320);
                        break;
                    case Keys.Left:
                        playerBox_move(-10, 320);
                        break;
                    case Keys.Space:
                        shootBox_start();
                        break;
                    default:
                        break;
                }
        }

        private void playerBox_move(int x, int y)
        {
            int positionX = 0;
            int positionY = 0;

            if (playerBox.Location.X >= 4 && playerBox.Location.X <= 700)
            {
                positionX = playerBox.Location.X + x;
                positionY = y;
            }
            else if (playerBox.Location.X < 4)
            {
                positionX = 4;
                positionY = playerBox.Location.Y;
            }
            else if (playerBox.Location.X > 700)
            {
                positionX = 700;
                positionY = playerBox.Location.Y;
            }

            BeginInvoke((Action)delegate
            {
                playerBox.Location = new Point(positionX, positionY);
            });

            
        }

        private void shootBox_start()
        {
            BeginInvoke((Action)async delegate
            {
                PictureBox shootBox = new PictureBox();
                this.Controls.Add(shootBox);
                int x = playerBox.Location.X;
                int y = playerBox.Location.Y;

                shootBox.BackColor = Color.Transparent;
                shootBox.Image = Properties.Resources.Fx_04_1;
                shootBox.Location = new Point(x + 28, y - 10);


                while (shootBox.Location.Y > 88)
                {
                    await Task.Delay(1);

                    shootBox.Location = new Point(shootBox.Location.X, shootBox.Location.Y - 5);

                    if (shootBox.Location.Y == 260)
                        shootBox.Image = Properties.Resources.Fx_04_2;
                    if (shootBox.Location.Y == 140)
                        shootBox.Image = Properties.Resources.Fx_04_3;
                }

                int enemyLocation = enemyBox.Location.X;
                int shotLocation = shootBox.Location.X;
                if (shotLocation >= enemyLocation && shotLocation <= (enemyLocation + enemyBox.Width / 2))
                {
                    _player.CurrentPoints += points;
                    pointsLabel.Text = "POINTS " + _player.CurrentPoints.ToString();

                    if (_player.CurrentPoints % 50 == 0 && _player.CurrentPoints != 0)
                    {
                        _player.Level++;
                        levelLabel.Text = "LEVEL " + _player.Level.ToString();
                    }

                    ExplosionAnimation(enemyLocation);
                }

                this.Controls.Remove(shootBox);
                shootBox.Dispose();
            });
        }

        private async void ExplosionAnimation(int enemyLocation)
        {
            PictureBox explosionBox = new PictureBox();
            this.Controls.Add(explosionBox);
            explosionBox.Width = enemyBox.Width;
            explosionBox.Height = enemyBox.Height;

            explosionBox.BringToFront();
            explosionBox.BackColor = Color.Transparent;
            explosionBox.Location = new Point(enemyLocation, 100);
            explosionBox.Image = Properties.Resources.Explosion_1;
            await Task.Delay(explosionShowTime);
            explosionBox.Image = Properties.Resources.Explosion_2;
            await Task.Delay(explosionShowTime);
            explosionBox.Image = Properties.Resources.Explosion_3;
            await Task.Delay(explosionShowTime);
            explosionBox.Image = Properties.Resources.Explosion_4;
            await Task.Delay(explosionShowTime);
            explosionBox.Image = Properties.Resources.Explosion_5;
            await Task.Delay(explosionShowTime);
            explosionBox.Image = Properties.Resources.Explosion_6;
            await Task.Delay(explosionShowTime);
            explosionBox.Image = Properties.Resources.Explosion_7;
            await Task.Delay(explosionShowTime);
            explosionBox.Image = Properties.Resources.Explosion_8;
            await Task.Delay(explosionShowTime);
            this.Controls.Remove(explosionBox);
            explosionBox.Dispose();
        }
    }
}
