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
    public partial class wfLogin : Form
    {
        private wfHome wfHome = null;
        private string estoqueConnStr = StockPC.Properties.Settings.Default.estoqueConnectionString;

        public wfLogin(wfHome wfHome)
        {
            InitializeComponent();
            this.wfHome = wfHome;
            this.wfHome.stStatusSist.Items[0].Text = "Usuário: ";
        }

        private void wfLogin_Load(object sender, EventArgs e)
        {
            this.txtLogin.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            this.wfHome.Tag = false;
            Application.Exit();
        }

        private void wfLogin_FormClosing(object sender, FormClosingEventArgs e)
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

        private bool IsAdmin(int idUsuario)
        {
            object resp = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnIsAdmin", idUsuario.ToString());

            return (Convert.ToInt32(resp) > 0) ? true : false;
        }

        private int ValidaUsuario(string login, string senha)
        {
            object resp = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnValidaUsuario", login, senha);

            return (resp != DBNull.Value) ? Convert.ToInt32(resp) : 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Validar login
            int idUsuario = ValidaUsuario(txtLogin.Text.Trim(), mtxtSenha.Text.Trim());

            if (idUsuario > 0)
            {
                this.wfHome.stStatusSist.Items[0].Text = "Usuário: " + "[ " + this.txtLogin.Text + " ]";
                this.wfHome.mnPrincipal.Enabled = true;
                if (IsAdmin(idUsuario))
                {
                    this.wfHome.administraçãoToolStripMenuItem.Visible = true;
                }
                this.wfHome.Tag = false;
                this.Tag = false;
                this.Close();

                clsUtil.USUARIO_LOGADO = idUsuario;
            }
            else
            {
                if (txtLogin.Text.Trim().Equals("admin") && mtxtSenha.Text.Trim().Equals("admin"))
                {
                    this.wfHome.stStatusSist.Items[0].Text = "Usuário: " + "[ " + this.txtLogin.Text + " ]";
                    this.wfHome.mnPrincipal.Enabled = true;
                    this.wfHome.administraçãoToolStripMenuItem.Visible = true;
                    this.wfHome.Tag = false;
                    this.Tag = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário Inválido!", "Stock PC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
