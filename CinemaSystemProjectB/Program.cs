﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			/*JObject Movies;
            if (File.Exists("Movies.json")) {
				Movies = JObject.Parse(File.ReadAllText("Movies.json"));
			} else {
                File.CreateText("")
			}
            
            */


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MovieOverview());
        }
    }
}
