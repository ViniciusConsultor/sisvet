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
    public partial class wfCadProduto : Form
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
        public wfCadProduto()
        {
            InitializeComponent();
        }
        #endregion

        #region -- Carregamento Form --
        private void wfCadProduto_Load(object sender, EventArgs e)
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetProdutos", ref this.Grid);
            PreencheCategorias();
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

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtCategoria.Text = this.cbCategoria.Items.Cast<DataRowView>()
                .Where(t => t[0].ToString().Equals(GetValorColuna(5)))
                .Select(t => t[1].ToString())
                .SingleOrDefault();
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
                            this.txtDescricao.Text,
                            (this.txtValorCusto.Text.Length > 0) ? this.txtValorCusto.Text : "0",
                            (this.txtValorVenda.Text.Length > 0) ? this.txtValorVenda.Text : "0",
                            (this.txtQtdeTotal.Text.Length > 0) ? this.txtQtdeTotal.Text : "0",
                            this.cbCategoria.SelectedValue.ToString());
                        break;
                }
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            CarregaCampos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (this.txtDescricao_F.Text.Length != 0 || this.cbCategoria_F.SelectedIndex != 0)
            {
                CarregarGrid(this.txtDescricao_F.Text, this.cbCategoria_F.SelectedValue.ToString());
            }
            else
            {
                CarregarGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            CarregaCampos();
        }

        private void ValidaInteiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region -- Métodos Utilitários --
        private void PreencheCategorias()
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetName_Categorias", ref this.cbCategoria);
            clsUtil.TrazerDados(estoqueConnStr, "fnGetName_Categorias", ref this.cbCategoria_F);
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
                    SelecCategoria(this.txtCategoria.Text);
                    break;
            }
            this.btnCancelar.Enabled = true;

            this.txtDescricao.ReadOnly = false;
            this.txtValorCusto.ReadOnly = false;
            this.txtValorVenda.ReadOnly = false;
            this.txtQtdeTotal.ReadOnly = false;
            DesabilitaCategoria_Simples();
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

            this.txtDescricao.ReadOnly = true;
            this.txtValorCusto.ReadOnly = true;
            this.txtValorVenda.ReadOnly = true;
            this.txtQtdeTotal.ReadOnly = true;
            HabilitaCategoria_Simples();
            this.Grid.Enabled = true;
            this.pnBarraFiltro.Enabled = true;
            this.pnBarraFiltro.BackColor = Color.DarkTurquoise;

            this.btnNovo.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnExcluir.Enabled = true;
        }

        private void LimparCampos()
        {
            this.txtDescricao.Text = string.Empty;
            this.txtValorCusto.Text = string.Empty;
            this.txtValorVenda.Text = string.Empty;
            this.txtQtdeTotal.Text = string.Empty;
            this.cbCategoria.SelectedIndex = 0;
        }

        private void HabilitaCategoria_Simples()
        {
            this.txtCategoria.Visible = true;
            this.cbCategoria.Visible = false;
        }
        private void DesabilitaCategoria_Simples()
        {
            this.txtCategoria.Visible = false;
            this.cbCategoria.Visible = true;
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
                string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnDeleteProduto", id.ToString()).ToString();
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
            clsUtil.TrazerDados(estoqueConnStr, "fnGetProdutos", ref this.Grid, valores);
        }

        private void MensagemAcao(string msg, string numMsg)
        {
            MessageBox.Show(msg, "Stock PC", MessageBoxButtons.OK, (!ExisteErro(numMsg)) ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private bool ExisteErro(string numMsg)
        {
            return (numMsg.Equals("1")) ? true : false;
        }

        private void SelecCategoria(string categoria)
        {
            foreach (DataRowView item in this.cbCategoria.Items.Cast<DataRowView>())
            {
                string str = item.Row[0].ToString();
                if (str.Equals(categoria))
                {
                    this.cbCategoria.SelectedIndex = this.cbCategoria.Items.IndexOf(item);
                }
            }
        }

        private void Salvar()
        {
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr,
                "fnAddProduto",
                this.txtDescricao.Text,
                (this.txtValorCusto.Text.Length > 0) ? this.txtValorCusto.Text : "0",
                (this.txtValorVenda.Text.Length > 0) ? this.txtValorVenda.Text : "0",
                (this.txtQtdeTotal.Text.Length > 0) ? this.txtQtdeTotal.Text : "0",
                this.cbCategoria.SelectedValue.ToString())
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
                "fnUpdateProduto", id.ToString(), valores[0], valores[1], valores[2], valores[3], valores[4]).ToString();
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
                this.txtDescricao.Text = GetValorColuna(1);
                this.txtValorCusto.Text = GetValorColuna(2);
                this.txtValorVenda.Text = GetValorColuna(3);
                this.txtQtdeTotal.Text = GetValorColuna(4);
                HabilitaCategoria_Simples();
                SelecCategoria(GetValorColuna(5));
            }
        }
        #endregion
    }
}
