﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP1
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
            //Application.Run(new Form1());

            CheckInputForm InForm = new CheckInputForm();
            Application.Run(InForm);

            // Here are your gets, copypasta and use where needed. 

            // InForm.getName();
            // InForm.getAmount();
            // InForm.getMemo();
        }
    }
}