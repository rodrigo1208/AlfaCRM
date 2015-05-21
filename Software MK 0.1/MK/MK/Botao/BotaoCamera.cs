using System;
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
    public partial class BotaoCamera : UserControl
    {
        public BotaoCamera()
        {
            InitializeComponent();
        }

        private void BotaoCamera_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCamera2;
        }

        private void BotaoCamera_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoCamera1;
        }
    }
}
