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
    public partial class wfCadCategoria : Form
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
        public wfCadCategoria()
        {
            InitializeComponent();
        }
        #endregion

        #region -- Carregamento Form --
        private void wfCadCategoria_Load(object sender, EventArgs e)
        {
            CarregarGrid();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            CarregaCampos();
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
                        Atualizar(Convert.ToInt32(GetValorColuna(0)), this.txtNome.Text, this.txtDescricao.Text);
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
        private void CarregaCampos()
        {
            if (this.Grid.Rows.Count > 0)
            {
                this.txtNome.Text = GetValorColuna(1);
                this.txtDescricao.Text = GetValorColuna(2);
            }
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
                    break;
            }
            this.btnCancelar.Enabled = true;

            this.txtNome.ReadOnly = false;
            this.txtDescricao.ReadOnly = false;
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
            this.txtDescricao.ReadOnly = true;
            this.Grid.Enabled = true;
            this.pnBarraFiltro.Enabled = true;
            this.pnBarraFiltro.BackColor = Color.DarkTurquoise;

            this.btnNovo.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnExcluir.Enabled = true;
        }

        private void Salvar()
        {
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnaddcategoria", this.txtNome.Text, this.txtDescricao.Text).ToString();
            string numMsg = msg.Split('|')[0];
            //0|Mensagem
            //1|Mensagem
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
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnupdatecategoria", id.ToString(), valores[0], valores[1]).ToString();
            string numMsg = msg.Split('|')[0];
            msg = msg.Split('|')[1];

            MensagemAcao(msg, numMsg);

            if (!ExisteErro(numMsg))
            {
                CarregarGrid();
                DesabilitaEdicao();
            }
        }

        private void Deletar(int id)
        {
            if (MessageBox.Show("Deseja mesmo excluir este item?", "Stock PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 
                System.Windows.Forms.DialogResult.Yes)
            {
                string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fndeletecategoria", id.ToString()).ToString();
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

        private void LimparCampos()
        {
            this.txtNome.Text = string.Empty;
            this.txtDescricao.Text = string.Empty;
        }

        private string GetValorColuna(int posicao)
        {
            return this.Grid.Rows[Grid.CurrentRow.Index].Cells[posicao].Value.ToString();
        }
        private string GetValorColuna(string coluna)
        {
            return this.Grid.Rows[Grid.CurrentRow.Index].Cells[coluna].Value.ToString();
        }

        private void CarregarGrid(params string[] valores)
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetCategorias", ref this.Grid, valores);
        }

        private void MensagemAcao(string msg, string numMsg)
        {
            MessageBox.Show(msg, "Stock PC", MessageBoxButtons.OK, (!ExisteErro(numMsg)) ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private bool ExisteErro(string numMsg)
        {
            return (numMsg.Equals("1")) ? true : false;
        }
        #endregion
    }
}
