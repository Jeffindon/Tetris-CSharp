﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace Tetris
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TetrisGame tetris = new TetrisGame();
            Application.Run(tetris);
        }
    }
}
