﻿using ObjectOrientedPractice.Services;
using ObjectOrientedPractice.View;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractice
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
