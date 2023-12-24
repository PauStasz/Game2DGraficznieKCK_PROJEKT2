using Game.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Game
{
    internal class Database
    {
        private string name;
        public Database(string name)
        {
            this.name = name;
        }

        public void SerializeToFile(List<Player> players)
        {
            foreach (Player player in players)
            {
                MemoryStream stream = new MemoryStream();
                player.Icon.Save(stream, ImageFormat.Png);
                player.ConvertedIcon = stream.ToArray();
            }

            var serializedPlayers = JsonSerializer.Serialize(players);
            File.WriteAllText(name, serializedPlayers);
        }

        public List<Player> DeserializeFromFile()
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name);
                try
                {   

                        var serializedPlayers = File.ReadAllText(fullPath);
                        List<Player> players = JsonSerializer.Deserialize<List<Player>>(serializedPlayers);

                        if(players != null && players.Count > 0)
                            foreach (Player player in players)
                            {
                                MemoryStream stream = new MemoryStream(player.ConvertedIcon);
                                player.Icon = new Bitmap(stream);
                            }

                        return players;

                }
                catch (Exception e)
                {
                    SaveNoDatebaseInformation(e);
                }

               return null;      
        }

        private void SaveNoDatebaseInformation(Exception e)
        {
            using (StreamWriter writer = new StreamWriter("No_database_in_game_info.txt", true))
            {
                DateTime dateTime = DateTime.Now;
                writer.WriteLine(e.Message + " There's no database at time " + dateTime);
                MessageBox.Show(e.Message + " There's no database at time " + dateTime, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
