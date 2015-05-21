namespace MK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoCliente1 = new MK.Botao.BotaoCliente();
            this.botaoCamera1 = new MK.Botao.BotaoCamera();
            this.botaoCadastrarCamera1 = new MK.Botao.BotaoCadastrarCamera();
            this.botaoAdicionarCliente1 = new MK.Botao.BotaoAdicionarCliente();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.botaoCadastrarCamera1);
            this.panel1.Controls.Add(this.botaoAdicionarCliente1);
            this.panel1.Location = new System.Drawing.Point(268, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 347);
            this.panel1.TabIndex = 2;
            // 
            // botaoCliente1
            // 
            this.botaoCliente1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCliente1.BackgroundImage")));
            this.botaoCliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCliente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCliente1.Location = new System.Drawing.Point(12, 98);
            this.botaoCliente1.Name = "botaoCliente1";
            this.botaoCliente1.Size = new System.Drawing.Size(250, 80);
            this.botaoCliente1.TabIndex = 4;
            // 
            // botaoCamera1
            // 
            this.botaoCamera1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCamera1.BackgroundImage")));
            this.botaoCamera1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCamera1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCamera1.Location = new System.Drawing.Point(12, 12);
            this.botaoCamera1.Name = "botaoCamera1";
            this.botaoCamera1.Size = new System.Drawing.Size(250, 80);
            this.botaoCamera1.TabIndex = 3;
            // 
            // botaoCadastrarCamera1
            // 
            this.botaoCadastrarCamera1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCadastrarCamera1.BackgroundImage")));
            this.botaoCadastrarCamera1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCadastrarCamera1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCadastrarCamera1.Location = new System.Drawing.Point(21, 89);
            this.botaoCadastrarCamera1.Name = "botaoCadastrarCamera1";
            this.botaoCadastrarCamera1.Size = new System.Drawing.Size(400, 80);
            this.botaoCadastrarCamera1.TabIndex = 1;
            // 
            // botaoAdicionarCliente1
            // 
            this.botaoAdicionarCliente1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdicionarCliente1.BackgroundImage")));
            this.botaoAdicionarCliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAdicionarCliente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionarCliente1.Location = new System.Drawing.Point(21, 3);
            this.botaoAdicionarCliente1.Name = "botaoAdicionarCliente1";
            this.botaoAdicionarCliente1.Size = new System.Drawing.Size(400, 80);
            this.botaoAdicionarCliente1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(710, 452);
            this.Controls.Add(this.botaoCliente1);
            this.Controls.Add(this.botaoCamera1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Botao.BotaoCadastrarCamera botaoCadastrarCamera1;
        private Botao.BotaoAdicionarCliente botaoAdicionarCliente1;
        private Botao.BotaoCamera botaoCamera1;
        private Botao.BotaoCliente botaoCliente1;
    }
}

