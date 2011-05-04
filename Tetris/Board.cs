﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    /// <summary>
    /// The game board
    /// </summary>
    class Board
    {
        /// <summary>
        /// The board that is being played on
        /// </summary>
        int[,] board = new int[10,22];

        /// <summary>
        /// The block that is currently being played
        /// </summary>
        Block currentBlock;

        /// <summary>
        /// Ticks the board forward one move
        /// </summary>
        public void tick()
        {
            if (currentBlock == null || !canDropFurther())
            {
                spawnBlock();
            }

            lowerBlock();
        }

        #region Board

        /// <summary>
        /// Creates a new block to play with
        /// </summary>
        private void spawnBlock()
        {
            currentBlock = new Block();
        }

        /// <summary>
        /// Lowers the current block down one row
        /// </summary>
        private void lowerBlock()
        {
            currentBlock.y++;
        }

        /// <summary>
        /// Checks to see whether there is a square in the specified position on the Board
        /// </summary>
        /// <param name="coord">The coordinate to check</param>
        /// <returns>Whether there is a square there or not</returns>
        private Boolean hasSquare(Coordinate coord)
        {
            Boolean hasSquare = false;

            if (board[coord.x, coord.y] != 0)
            {
                hasSquare = true;
            }

            return hasSquare;
        }

        /// <summary>
        /// Checks to see whether there is a square in the position on the Board below the specified coordinate
        /// </summary>
        /// <param name="coord">The coordinate to check below</param>
        /// <returns>Whether there is a square there or not</returns>
        private Boolean hasSquareBelow(Coordinate coord)
        {
            coord.x++;

            return hasSquare(coord);
        }

        #endregion Board

        #region Block

        /// <summary>
        /// Checks to see whether the block can drop any futher
        /// </summary>
        /// <returns>Indicates whether the current block can drop any further</returns>
        private Boolean canDropFurther()
        {
            Boolean canDrop = true;

            if (blockIsOnBottom() || blockIsOnPile())
            {
                canDrop = false;
            }

            return canDrop;
        }

        /// <summary>
        /// Checks to see whether the block is on the bottom of the board
        /// </summary>
        /// <returns>Indicates whether the current block is on the bottom of the board</returns>
        private Boolean blockIsOnBottom()
        {
            Boolean onBottom = false;

            if (currentBlock.x + currentBlock.lowestRowWithSquareIn() > board.GetLength(0) - 1)
            {
                onBottom = true;
            }

            return onBottom;
        }

        /// <summary>
        /// Checks to see whether the block is on the pile of blocks at the bottom of the board
        /// </summary>
        /// <returns>Indicates whether the current block is on the pile of blocks at the bottom of the board</returns>
        private Boolean blockIsOnPile()
        {
            Boolean onPile = false;

            int lowestRow = currentBlock.lowestRowWithSquareIn();
            List<int> lowestColumns = currentBlock.columnsWithLowestSquaresIn();

            // loop through and check whether any of the lowest sqaures are sitting on anything
            foreach (int col in lowestColumns)
            {
                int x = currentBlock.x + col;
                int y = currentBlock.y + lowestRow;
                Coordinate squarePos = new Coordinate(x, y);

                if (hasSquareBelow(squarePos))
                {
                    onPile = true;
                }
            }

            return onPile;
        }

        #endregion Block
    }
}
