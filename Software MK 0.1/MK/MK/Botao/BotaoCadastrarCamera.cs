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
    public partial class BotaoCadastrarCamera : UserControl
    {
        public BotaoCadastrarCamera()
        {
            InitializeComponent();
        }

        private void BotaoCadastrarCamera_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarCamera2;
        }

        private void BotaoCadastrarCamera_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BotaoAdicionarCamera1;
        }
    }
}
