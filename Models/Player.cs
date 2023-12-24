using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    public class Player
    {
        public string Nick { get; set; }
        public int CurrentPoints { get; set; }
        public int Level { get; set; }

        public Bitmap Icon { get; set; }

        public Player(string nick, Bitmap icon) 
        {
            Nick = nick;
            CurrentPoints = 0;
            Level = 0;
            Icon = icon;
        }
        
    }
}
