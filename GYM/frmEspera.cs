﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class frmEspera : Form
    {
        public frmEspera(string mensaje)
        {
            InitializeComponent();

            lblMensaje.Text = mensaje;
            lblMensaje.Left = (this.Width - lblMensaje.Width) / 2;
        }
    }
}
