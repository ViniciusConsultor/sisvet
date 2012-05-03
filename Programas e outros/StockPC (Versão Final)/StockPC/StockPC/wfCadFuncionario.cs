using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace StockPC
{
    public partial class wfCadFuncionario : Form
    {
        #region -- Variáveis Principais --
        private string estoqueConnStr = StockPC.Properties.Settings.Default.estoqueConnectionString;
        private enum Acao
        {
            Inserir,
            Alterar,
            Deletar
        }
        #endregion

        #region -- Construtores --
        public wfCadFuncionario()
        {
            InitializeComponent();
        }
        #endregion

        #region -- Carregamento Form --
        private void wfCadFuncionario_Load(object sender, EventArgs e)
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetFuncionarios", ref this.Grid);
        }
        #endregion

        #region -- Eventos Form --
        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaEdicao(Acao.Inserir);
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao(Acao.Alterar);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Deletar(Convert.ToInt32(GetValorColuna(0)));

            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo salvar as configurações?", "Stock PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                string msg = string.Empty;
                string numMsg = string.Empty;

                switch ((Acao)((Button)sender).Tag)
                {
                    case Acao.Inserir:
                        Salvar();
                        break;

                    case Acao.Alterar:
                        Atualizar(
                            GetValorColuna(0),
                            this.txtNome.Text,
                            this.txtCPF.Text,
                            this.txtRG.Text,
                            this.txtEndereco.Text,
                            (!string.IsNullOrEmpty(this.txtTelefone.Text)) ? this.txtTelefone.Text : null,
                            (!string.IsNullOrEmpty(this.txtE_mail.Text)) ? this.txtE_mail.Text : null,
                            this.txtCTPS.Text,
                            this.txtLogin.Text,
                            this.txtSenha.Text,
                            (this.rdMasc.Checked) ? "M" : ((this.rdFem.Checked) ? "F" : ""),
                            (this.chAdmin.Checked) ? "TRUE" : "FALSE");
                        break;
                }
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            CarregaCampos();
            if (clsUtil.USUARIO_LOGADO == Convert.ToInt32(GetValorColuna(0)))
            {
                this.btnExcluir.Enabled = false;
            }
            else
            {
                this.btnExcluir.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            CarregaCampos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (this.txtNome_F.Text.Length != 0 || this.txtCPF_F.Text.Length != 0 || this.txtRG_F.Text.Length != 0)
            {
                CarregarGrid(this.txtNome_F.Text, this.txtCPF_F.Text, this.txtRG_F.Text);
            }
            else
            {
                CarregarGrid();
            }
        }
        #endregion

        #region -- Métodos Utilitários --
        private void HabilitaEdicao(Acao acao)
        {
            this.btnSalvar.Enabled = true;
            this.btnSalvar.Tag = acao;
            switch (acao)
            {
                case Acao.Inserir:
                    this.pnStatusAdd.Visible = true;
                    break;

                case Acao.Alterar:
                    this.pnStatusAlt.Visible = true;
                    break;
            }
            this.btnCancelar.Enabled = true;

            this.txtNome.ReadOnly = false;
            this.txtCPF.ReadOnly = false;
            this.txtRG.ReadOnly = false;
            this.txtCTPS.ReadOnly = false;
            this.txtEndereco.ReadOnly = false;
            this.txtTelefone.ReadOnly = false;
            this.txtE_mail.ReadOnly = false;
            this.txtLogin.ReadOnly = false;
            this.txtSenha.ReadOnly = false;
            this.chAdmin.Enabled = true;
            this.rdMasc.Enabled = true;
            this.rdFem.Enabled = true;
            this.Grid.Enabled = false;
            this.pnBarraFiltro.Enabled = false;
            this.pnBarraFiltro.BackColor = Color.Azure;

            this.btnNovo.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnExcluir.Enabled = false;
        }

        private void DesabilitaEdicao()
        {
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Tag = null;
            this.pnStatusAdd.Visible = false;
            this.pnStatusAlt.Visible = false;
            this.btnCancelar.Enabled = false;

            this.txtNome.ReadOnly = true;
            this.txtCPF.ReadOnly = true;
            this.txtRG.ReadOnly = true;
            this.txtCTPS.ReadOnly = true;
            this.txtEndereco.ReadOnly = true;
            this.txtTelefone.ReadOnly = true;
            this.txtE_mail.ReadOnly = true;
            this.txtLogin.ReadOnly = true;
            this.txtSenha.ReadOnly = true;
            this.chAdmin.Enabled = false;
            this.rdMasc.Enabled = false;
            this.rdFem.Enabled = false;
            this.Grid.Enabled = true;
            this.pnBarraFiltro.Enabled = true;
            this.pnBarraFiltro.BackColor = Color.DarkTurquoise;

            this.btnNovo.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnExcluir.Enabled = true;
        }

        private void LimparCampos()
        {
            this.txtNome.Text = string.Empty;
            this.txtCPF.Text = string.Empty;
            this.txtRG.Text = string.Empty;
            this.txtCTPS.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
            this.txtE_mail.Text = string.Empty;
            this.txtLogin.Text = string.Empty;
            this.txtSenha.Text = string.Empty;
            this.chAdmin.Checked = false;
            this.rdMasc.Checked = false;
            this.rdFem.Checked = false;
        }

        private string GetValorColuna(int posicao)
        {
            return this.Grid.Rows[Grid.CurrentRow.Index].Cells[posicao].Value.ToString();
        }
        private string GetValorColuna(string coluna)
        {
            return this.Grid.Rows[Grid.CurrentRow.Index].Cells[coluna].Value.ToString();
        }

        private void Deletar(int id)
        {
            if (MessageBox.Show("Deseja mesmo excluir este item?", "Stock PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnDeleteFuncionario", id.ToString()).ToString();
                string numMsg = msg.Split('|')[0];
                msg = msg.Split('|')[1];
                
                MensagemAcao(msg, numMsg);

                if (!ExisteErro(numMsg))
                {
                    CarregarGrid();
                    DesabilitaEdicao();
                }
            }
        }

        private void CarregarGrid(params string[] valores)
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetFuncionarios", ref this.Grid, valores);
        }

        private void MensagemAcao(string msg, string numMsg)
        {
            MessageBox.Show(msg, "Stock PC", MessageBoxButtons.OK, (!ExisteErro(numMsg)) ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private bool ExisteErro(string numMsg)
        {
            return (numMsg.Equals("1")) ? true : false;
        }

        private void Salvar()
        {
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr,
                "fnAddFuncionario",
                this.txtNome.Text,
                this.txtCPF.Text,
                this.txtRG.Text,
                this.txtEndereco.Text,
                (!string.IsNullOrEmpty(this.txtTelefone.Text)) ? this.txtTelefone.Text : null,
                (!string.IsNullOrEmpty(this.txtE_mail.Text)) ? this.txtE_mail.Text : null,
                this.txtCTPS.Text,
                this.txtLogin.Text,
                this.txtSenha.Text,
                (this.rdMasc.Checked) ? "M" : ((this.rdFem.Checked) ? "F" : ""),
                (this.chAdmin.Checked) ? "TRUE" : "FALSE")
                .ToString();
            string numMsg = msg.Split('|')[0];
            msg = msg.Split('|')[1];

            MensagemAcao(msg, numMsg);

            if (!ExisteErro(numMsg))
            {
                CarregarGrid();
                DesabilitaEdicao();
            }
        }

        private void Atualizar(params string[] valores)
        {
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnUpdateFuncionario", valores).ToString();
            string numMsg = msg.Split('|')[0];
            
            msg = msg.Split('|')[1];

            MensagemAcao(msg, numMsg);

            if (!ExisteErro(numMsg))
            {
                CarregarGrid();
                DesabilitaEdicao();
            }
        }

        private void CarregaCampos()
        {
            if (this.Grid.Rows.Count > 0)
            {
                this.txtNome.Text = GetValorColuna(1);
                this.txtCPF.Text = GetValorColuna(2);
                this.txtRG.Text = GetValorColuna(3);
                this.txtEndereco.Text = GetValorColuna(4);
                this.txtTelefone.Text = GetValorColuna(5);
                this.txtE_mail.Text = GetValorColuna(6);
                this.txtCTPS.Text = GetValorColuna(7);
                this.txtLogin.Text = GetValorColuna(8);
                this.txtSenha.Text = GetValorColuna(9);
                SelecSexo(GetValorColuna(10));
                SelecAdmin(GetValorColuna(11));
            }
        }

        private void SelecSexo(string sexo)
        {
            this.rdMasc.Checked = (sexo.ToUpperInvariant().Equals("M")) ? true : false;
            this.rdFem.Checked = (sexo.ToUpperInvariant().Equals("F")) ? true : false;
        }

        private void SelecAdmin(string admin)
        {
            this.chAdmin.Checked = (admin.ToUpperInvariant().Equals("TRUE")) ? true : false;
        }
        #endregion
    }
}