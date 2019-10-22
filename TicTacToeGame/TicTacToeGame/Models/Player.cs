﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    internal class Player
    {
        public string Name { get; set; }

        public Player Opponent { get; set; }

        public bool IsPlaying { get; set; }

        public bool WaitingForMove { get; set; }

        public bool IsSearchingOpponent { get; set; }

        public DateTime RegisterTime { get; set; }

        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the connection id of the player connection with the gameHub
        /// </summary>
        public string ConnectionId { get; set; }
    }
}
