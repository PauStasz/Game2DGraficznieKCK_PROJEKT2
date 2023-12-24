using Game.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
            var serializedPlayers = JsonSerializer.Serialize(players);
            File.WriteAllText(name, serializedPlayers);
        }

        public List<Player> DeserializeFromFile()
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name);
            if (File.Exists(fullPath))
            {
                try
                {
                    var serializedPlayers = File.ReadAllText(fullPath);
                    List<Player> players = JsonSerializer.Deserialize<List<Player>>(serializedPlayers);
                    return players;

                }
                catch (Exception e)
                {
                    SaveNoDatebaseInformation(e);
                }
            }

            return null;
        }

        private void SaveNoDatebaseInformation(Exception e)
        {
            using (StreamWriter writer = new StreamWriter("No_database_in_game_info.txt", true))
            {
                DateTime dateTime = DateTime.Now;
                writer.WriteLine(e.Message + " There's no database at time " + dateTime);
            }

        }

    }
}
