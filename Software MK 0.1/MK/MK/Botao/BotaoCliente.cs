﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MK.Botao
{
    public partial class BotaoCliente : UserControl
    {
        public BotaoCliente()
        {
            InitializeComponent();
        }

        private void BotaoCliente_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCliente2;
        }

        private void BotaoCliente_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCliente1;
        }
    }
}
