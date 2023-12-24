using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Game.Models
{
    public class Player
    {
        public string Nick { get; set; }
        public int CurrentPoints { get; set; }
        public int Level { get; set; }

        [JsonIgnore]
        public Bitmap Icon { get; set; }

        public byte[] ConvertedIcon { get; set; }    

        public Player(string nick, Bitmap icon) 
        {
            Nick = nick;
            CurrentPoints = 0;
            Level = 0;
            Icon = icon;
        }
        
    }
}
