﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Game_Caro
{
    class Player
    {
        private string name;
        private Image avatar;
        private Image symbol;
        public string Name { get => name; set => name = value; }
        public Image Avatar { get => avatar; set => avatar = value; }
        public Image Symbol { get => symbol; set => symbol = value; }

        public Player(string name, Image avatar, Image symbol)
        {
            this.Name = name;
            this.Avatar = avatar;
            this.Symbol = symbol;
        }
    }
}
