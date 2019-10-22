using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    internal class Game
    {
        /// <summary>
        /// Gets or sets the value indicating whether the game is over.
        /// </summary>
        public bool IsOver { get; private set; }

        /// <summary>
        /// Gets or sets the value indicating whether the game is draw.
        /// </summary>
        public bool IsDraw { get; private set; }

        /// <summary>
        /// Gets or sets Player 1 of the game
        /// </summary>
        public Player Player1 { get; set; }

        /// <summary>
        /// Gets or sets Player 2 of the game
        /// </summary>
        public Player Player2 { get; set; }

        /// <summary>
        /// For internal housekeeping, To keep track of value in each of the box in the grid.
        /// </summary>
        private readonly int[] field = new int[9];

        /// <summary>
        /// The number of moves left. We start the game with 9 moves remaining in a 3x3 grid.
        /// </summary>
        private int movesLeft = 9;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Game" /> class.
        /// </summary>
        public Game()
        {
            //// Initialize the game
            for (var i = 0; i < field.Length; i++)
            {
                field[i] = -1;
            }
        }

        /// <summary>
        /// Place the player number at a given position for a player
        /// </summary>
        /// <param name="player">The player number would be 0 or 1</param>
        /// <param name="position">The position where player number would be placed, should be between 0 and
        /// 8, both inclusive</param>
        /// <returns>Boolean true if game is over and we have a winner.</returns>
        public bool Play(int player, int position)
        {
            if (this.IsOver)
            {
                return false;
            }
            //// Place the player number at the given position
            this.PlacePlayerNumber(player, position);
            //// Check if we have a winner. If this returns true, 
            //// game would be over and would have a winner, else game 
            /// would continue.
            return this.CheckWinner();
        }
    }
}
