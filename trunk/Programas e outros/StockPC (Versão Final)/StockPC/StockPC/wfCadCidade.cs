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
    public partial class wfCadCidade : Form
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
        public wfCadCidade()
        {
            InitializeComponent();
        }
        #endregion

        #region -- Carregamento Form --
        private void wfCadCidade_Load(object sender, EventArgs e)
        {
            PreencheEstados();
            clsUtil.TrazerDados(estoqueConnStr, "fnGetCidades", ref this.Grid);
            CarregaCampos();
        }
        #endregion

        #region -- Eventos Form --
        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaEdicao(Acao.Inserir);
            LimparCampos();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            CarregaCampos();
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
                        Atualizar(Convert.ToInt32(GetValorColuna(0)), this.txtNome.Text, this.cbEstado.SelectedValue.ToString());
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
            if (this.txtNome_F.Text.Length != 0)
            {
                CarregarGrid(this.txtNome_F.Text);
            }
            else
            {
                CarregarGrid();
            }
        }
        #endregion

        #region -- Métodos Utilitários --
        private void HabilitaEstado_Simples()
        {
            this.txtEstado.Visible = true;
            this.cbEstado.Visible = false;
        }
        private void DesabilitaEstado_Simples()
        {
            this.txtEstado.Visible = false;
            this.cbEstado.Visible = true;
        }

        private void SelecEstado(string estado)
        {
            foreach (DataRowView item in this.cbEstado.Items.Cast<DataRowView>())
            {
                string str = item.Row[0].ToString();
                if (str.Equals(estado))
                {
                    this.cbEstado.SelectedIndex = this.cbEstado.Items.IndexOf(item);
                }
            }
        }

        private void CarregaCampos()
        {
            if (this.Grid.Rows.Count > 0)
            {
                this.txtNome.Text = GetValorColuna(1);
                HabilitaEstado_Simples();
                this.txtEstado.Text = GetValorColuna(2);
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

        private void PreencheEstados()
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetEstados", ref this.cbEstado);
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
                    SelecEstado(this.txtEstado.Text);
                    break;
            }
            this.btnCancelar.Enabled = true;

            this.txtNome.ReadOnly = false;
            DesabilitaEstado_Simples();
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
            HabilitaEstado_Simples();
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
            this.txtEstado.Text = string.Empty;
            this.cbEstado.SelectedIndex = 0;
        }

        private void Deletar(int id)
        {
            if (MessageBox.Show("Deseja mesmo excluir este item?", "Stock PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnDeleteCidade", id.ToString()).ToString();
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
            clsUtil.TrazerDados(estoqueConnStr, "fnGetCidades", ref this.Grid, valores);
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
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnAddCidade", this.txtNome.Text, this.cbEstado.SelectedValue.ToString())
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
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnUpdateCidade", id.ToString(), valores[0], valores[1]).ToString();
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
