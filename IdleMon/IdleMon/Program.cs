﻿using System;
using System.Windows.Forms;

namespace idleMon
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            //This creates some exception handling globally that logs all uncaught errors to LOGFILE-err.txt
            AppDomain.CurrentDomain.UnhandledException += (s, e) => Utilities.Log(e.ExceptionObject.ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IdleMon.IdleMonContext());
        }
    }
}