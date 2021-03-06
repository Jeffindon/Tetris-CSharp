﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class Input
    {
        /// <summary>
        /// A central method of tracking keyboard input
        /// </summary>
        public Input()
        {
            leftKeyPressed = false;
            rightKeyPressed = false;
            rotateKeyPressed = false;
			downKeyPressed = false;
			swapKeyPressed = false;
			pauseKeyPressed = false;
			speedKeyPressed = false;
        }

        /// <summary>
        /// Process a specified key that has been pressed and set the relevant boolean value
        /// </summary>
        /// <param name="key">A character representing the key that has been pressed</param>
        /// <param name="pressed">Whether the key is pressed or has been lifted</param>
        public void processKey(char key, Boolean pressed)
        {
			if (key == downKey) {
				downKeyPressed = pressed;
			} else if (key == leftKey) {
				leftKeyPressed = pressed;
			} else if (key == rightKey) {
				rightKeyPressed = pressed;
			} else if (key == rotateKey) {
				rotateKeyPressed = pressed;
			} else if (key == swapKey) {
				swapKeyPressed = pressed;				
			} else if (key == pauseKey) {
				pauseKeyPressed = pressed;				
			} else if (key == speedKey) {
				speedKeyPressed = pressed;
			}
        }

        #region variables

        #region keys

        /// <summary>
        /// The key to move the current block left
        /// </summary>
        public readonly char leftKey = 'a';

        /// <summary>
        /// The key to move the current block right
        /// </summary>
        public readonly char rightKey = 'd';

        /// <summary>
        /// The key to rotate the block 90 degrees clockwise
        /// </summary>
        public readonly char rotateKey = 'w';

        /// <summary>
        /// The key to move the block down one row
        /// </summary>
        public readonly char downKey = 's';

		/// <summary>
		/// The key to move the block immediately to the bottom of the playfield
		/// </summary>
		public readonly char speedKey = 'q';

		/// <summary>
		/// The key to swap the block
		/// </summary>
		public readonly char swapKey = 'x';

		/// <summary>
		/// The key to pause the block
		/// </summary>
		public readonly char pauseKey = 'p';

        #endregion keys

        #region keyStatuses

        /// <summary>
        /// Indicates whether the left key is pressed or not
        /// </summary>
        public Boolean leftKeyPressed { get; set; }

        /// <summary>
        /// Indicates whether the right key is pressed or not
        /// </summary>
        public Boolean rightKeyPressed { get; set; }

        /// <summary>
        /// Indicates whether the rotate key is pressed or not
        /// </summary>
        public Boolean rotateKeyPressed { get; set; }

        /// <summary>
        /// Indicates whether the down key is pressed or not
        /// </summary>
        public Boolean downKeyPressed { get; set; }

		/// <summary>
		/// Indicates whether the speed key is pressed or not
		/// </summary>
		public Boolean speedKeyPressed { get; set; }

		/// <summary>
		/// Indicates whether the space key is pressed or not
		/// </summary>
		public Boolean swapKeyPressed { get; set; }

		/// <summary>
		/// Indicates whether the pause key is pressed or not
		/// </summary>
		public Boolean pauseKeyPressed { get; set; }

        #endregion keyStatuses

        #endregion variables
    }
}
