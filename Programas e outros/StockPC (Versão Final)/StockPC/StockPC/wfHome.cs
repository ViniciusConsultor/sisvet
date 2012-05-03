using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockPC
{
    public partial class wfHome : Form
    {
        public wfHome()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void wfHome_Load(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfLogin(this));
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            this.Close();
        }

        private void wfHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag == null)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (Application.OpenForms.Count > 1)
            {
                Application.OpenForms[1].Dispose();
            }

            this.Tag = null;
            this.mnPrincipal.Enabled = false;
            this.administraçãoToolStripMenuItem.Visible = false;
            clsUtil.USUARIO_LOGADO = 0;

            clsUtil.OpenForm(this, new wfLogin(this));
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfCadCategoria());
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfCadProduto());
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfCadCidade());
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfCadFornecedor());
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfCadPedido());
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfCadFuncionario());
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfRelCategoria());
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfRelPedido());
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfRelProduto());
        }

        private void cidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfRelCidade());
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfRelFornecedor());
        }

        private void relatórioDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtil.OpenForm(this, new wfRelFuncionario());
        }
    }
}
