﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace GYM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex instanceLock = new Mutex(false, "GYM");
            if (instanceLock.WaitOne(0, false))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Init());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                { instanceLock.ReleaseMutex(); }
            }
            else
            {
                MessageBox.Show("¡Gym CSY ya se esta ejecutando!", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public class Init : ApplicationContext
        {
            public Init()
            {
                (new frmSplash()).Show();
            }
        }
    }
}
