﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiDau
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
            //frmLogin log = new frmLogin();
            //log.StartPosition = FormStartPosition.CenterScreen;
            //Application.Run(log);
            Application.Run(new frmLogin());
        }
    }
}
