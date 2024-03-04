﻿using System;
using System.Windows.Forms;

namespace SnakeGame
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Splash();
            form.Show();
            Application.Run();
        }
    }
}
