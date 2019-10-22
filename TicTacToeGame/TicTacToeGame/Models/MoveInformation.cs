using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    public class MoveInformation
    {
        /// <summary>
        /// Gets or sets the opponent name.
        /// </summary>
        public string OpponentName { get; set; }

        /// <summary>
        /// Gets or sets the player who made the move.
        /// </summary>
        public string MoveMadeBy { get; set; }

        /// <summary>
        /// Gets or sets the image position. The position in the game 
        /// board(0-8) where the player placed his
        /// image.
        /// </summary>
        public int ImagePosition { get; set; }

        /// <summary>
        /// Gets or sets the image. The image of the player that he 
        /// placed in the board(0-8)
        /// </summary>
        public string Image { get; set; }
    }
}
