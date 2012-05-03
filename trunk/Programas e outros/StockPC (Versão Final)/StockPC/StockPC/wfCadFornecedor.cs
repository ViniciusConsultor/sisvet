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
    public partial class wfCadFornecedor : Form
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
        public wfCadFornecedor()
        {
            InitializeComponent();
        }
        #endregion

        #region -- Carregamento Form --
        private void wfCadFornecedor_Load(object sender, EventArgs e)
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetFornecedores", ref this.Grid);
            PreencheCidades();
        }
        #endregion

        #region -- Eventos Form --
        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtCidade.Text = this.cbCidade.Items.Cast<DataRowView>()
                .Where(t => t[0].ToString().Equals(GetValorColuna(6)))
                .Select(t => t[1].ToString())
                .SingleOrDefault();
        }

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
                            Convert.ToInt32(GetValorColuna(0)),
                            this.txtNome.Text,
                            this.txtCNPJ.Text,
                            this.txtEndereco.Text,
                            (!string.IsNullOrEmpty(this.txtTelefone.Text)) ? this.txtTelefone.Text : null,
                            (!string.IsNullOrEmpty(this.txtE_mail.Text)) ? this.txtE_mail.Text : null,
                            this.cbCidade.SelectedValue.ToString());
                        break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            CarregaCampos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (this.txtNome_F.Text.Length != 0 || this.txtCNPJ_F.Text.Length != 0)
            {
                CarregarGrid(this.txtNome_F.Text, this.txtCNPJ_F.Text.Replace(",", "."));
            }
            else
            {
                CarregarGrid();
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            CarregaCampos();
        }
        #endregion

        #region -- Métodos Utilitários --
        private void PreencheCidades()
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetName_Cidades", ref this.cbCidade);
        }

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
                    SelecCidade(this.txtCidade.Text);
                    break;
            }
            this.btnCancelar.Enabled = true;

            this.txtNome.ReadOnly = false;
            this.txtCNPJ.ReadOnly = false;
            this.txtEndereco.ReadOnly = false;
            this.txtTelefone.ReadOnly = false;
            this.txtE_mail.ReadOnly = false;
            DesabilitaCidade_Simples();
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
            this.txtCNPJ.ReadOnly = true;
            this.txtEndereco.ReadOnly = true;
            this.txtTelefone.ReadOnly = true;
            this.txtE_mail.ReadOnly = true;
            HabilitaCidade_Simples();
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
            this.txtCNPJ.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
            this.txtE_mail.Text = string.Empty;
            this.cbCidade.SelectedIndex = 0;
        }

        private void HabilitaCidade_Simples()
        {
            this.txtCidade.Visible = true;
            this.cbCidade.Visible = false;
        }
        private void DesabilitaCidade_Simples()
        {
            this.txtCidade.Visible = false;
            this.cbCidade.Visible = true;
        }

        private void SelecCidade(string cidade)
        {
            foreach (DataRowView item in this.cbCidade.Items.Cast<DataRowView>())
            {
                string str = item.Row[0].ToString();
                if (str.Equals(cidade))
                {
                    this.cbCidade.SelectedIndex = this.cbCidade.Items.IndexOf(item);
                }
            }
        }

        private void CarregaCampos()
        {
            if (this.Grid.Rows.Count > 0)
            {
                this.txtNome.Text = GetValorColuna(1);
                this.txtCNPJ.Text = GetValorColuna(2);
                this.txtEndereco.Text = GetValorColuna(3);
                this.txtTelefone.Text = GetValorColuna(4);
                this.txtE_mail.Text = GetValorColuna(5);
                HabilitaCidade_Simples();
                SelecCidade(GetValorColuna(6));
            }
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
                string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnDeleteFornecedor", id.ToString()).ToString();
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
            clsUtil.TrazerDados(estoqueConnStr, "fnGetFornecedores", ref this.Grid, valores);
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
                "fnAddFornecedor", 
                this.txtNome.Text,
                this.txtCNPJ.Text,
                this.txtEndereco.Text,
                (!string.IsNullOrEmpty(this.txtTelefone.Text)) ? this.txtTelefone.Text : null,
                (!string.IsNullOrEmpty(this.txtE_mail.Text)) ? this.txtE_mail.Text : null,
                this.cbCidade.SelectedValue.ToString())
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

        private void Atualizar(int id, params string[] valores)
        {
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr,
                "fnUpdateFornecedor", id.ToString(), valores[0], valores[1], valores[2], valores[3], valores[4], valores[5]).ToString();
            string numMsg = msg.Split('|')[0];
            msg = msg.Split('|')[1];

            MensagemAcao(msg, numMsg);

            if (!ExisteErro(numMsg))
            {
                CarregarGrid();
                DesabilitaEdicao();
            }
        }
        #endregion
    }
}
