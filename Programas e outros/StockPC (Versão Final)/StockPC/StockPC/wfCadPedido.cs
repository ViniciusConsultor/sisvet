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
    public partial class wfCadPedido : Form
    {
        #region -- Variáveis Principais --
        private string estoqueConnStr = StockPC.Properties.Settings.Default.estoqueConnectionString;
        private string[] itemsSituacao = new string[] { "-- Todas --", "Entregue", "Não Entregue" };
        bool isAdmin = false;
        private enum Acao
        {
            Inserir,
            Alterar,
            Deletar
        }
        private DataTable itemsIn_DB = new DataTable();
        private DataTable itemsToInsert_DB = new DataTable();
        private DataTable itemsToUpdate_DB = new DataTable();
        private DataTable itemsToDelete_DB = new DataTable();
        #endregion

        #region -- Construtores --
        public wfCadPedido()
        {
            InitializeComponent();
        }
        #endregion

        #region -- Carregamento Form --
        private void wfCadPedido_Load(object sender, EventArgs e)
        {
            isAdmin = IsAdmin();

            CarregarGridPedidos();
            PreencheSituacao();
            PreencheFornecedores();
            PreencheFuncionarios();
            PreencheProdutos();
        }
        #endregion

        #region -- Eventos Form --
        private void GridPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitaConsulta();
            CarregarGridItens();
        }

        private void tabctrDados_Selected(object sender, TabControlEventArgs e)
        {
            if (tabctrDados.Tag == null)
            {
                SelecLista();
            }

            if (this.btnSalvar.Tag != null)
            {
                SelecDetalhes();
            }

            if (tabctrDados.SelectedIndex == 0)
            {
                DesabilitaConsulta();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            HabilitaConsulta();
            CarregarGridItens();
        }

        private void GridPedidos_SelectionChanged(object sender, EventArgs e)
        {
            CarregaCampos();
        }

        private void cbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFuncionario.Text = this.cbFuncionario.Items.Cast<DataRowView>()
                .Where(t => t[0].ToString().Equals(GetValorColuna(1, this.GridPedidos)))
                .Select(t => t[1].ToString())
                .SingleOrDefault();
        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFornecedor.Text = this.cbFornecedor.Items.Cast<DataRowView>()
                .Where(t => t[0].ToString().Equals(GetValorColuna(2, this.GridPedidos)))
                .Select(t => t[1].ToString())
                .SingleOrDefault();
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.GridItens.Rows.Count > 0)
            {
                this.txtProduto.Text = this.cbProduto.Items.Cast<DataRowView>()
                    .Where(t => t[0].ToString().Equals(GetValorColuna(1, this.GridItens)))
                    .Select(t => t[1].ToString())
                    .SingleOrDefault();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaEdicao(Acao.Inserir);
            LimparCampos();
        }
        #endregion

        #region -- Métodos Utilitários --
        private void CarregarGridPedidos()
        {
            if (clsUtil.USUARIO_LOGADO == 0 || isAdmin)
            {
                clsUtil.TrazerDados(estoqueConnStr, "fnGetPedidos", ref GridPedidos);
            }
            else
            {
                clsUtil.TrazerDados(estoqueConnStr, "fnGetPedidos", ref GridPedidos, clsUtil.USUARIO_LOGADO.ToString());
            }
        }

        private void CarregarGridItens()
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetItems_Pedido", ref this.GridItens, GetValorColuna(0, this.GridPedidos));
        }

        private void CarregarItemsIn_DB()
        {
            itemsIn_DB.Columns.AddRange(this.GridItens.Columns.Cast<DataGridViewColumn>().Select(t => new DataColumn(t.Name)).ToArray());
            foreach (DataGridViewRow row in this.GridItens.Rows.Cast<DataGridViewRow>())
            {
                itemsIn_DB.Rows.Add(row);
            }
        }

        private bool IsAdmin()
        {
            object resp = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnIsAdmin", clsUtil.USUARIO_LOGADO.ToString());

            return (Convert.ToInt32(resp) > 0) ? true : false;
        }

        private void PreencheSituacao()
        {
            this.cbSituacao_F.DataSource = itemsSituacao;
        }

        private void PreencheFuncionarios()
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetName_Funcionarios", ref this.cbFuncionario);
        }

        private void PreencheFornecedores()
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetName_Fornecedores", ref this.cbFornecedor);
            clsUtil.TrazerDados(estoqueConnStr, "fnGetName_Fornecedores", ref this.cbFornecedor_F);
        }

        private void PreencheProdutos()
        {
            clsUtil.TrazerDados(estoqueConnStr, "fnGetName_Produtos", ref this.cbProduto);
            clsUtil.TrazerDados(estoqueConnStr, "fnGetName_Produtos", ref this.cbProduto_F);
        }

        private string GetValorColuna(int posicao, DataGridView Grid)
        {
            return Grid.Rows[Grid.CurrentRow.Index].Cells[posicao].Value.ToString();
        }
        private string GetValorColuna(string coluna, DataGridView Grid)
        {
            return Grid.Rows[Grid.CurrentRow.Index].Cells[coluna].Value.ToString();
        }

        private void CarregaCampos()
        {
            if (this.GridPedidos.Rows.Count > 0)
            {
                HabilitaFuncionario_Simples();
                SelecFuncionario(GetValorColuna(1, this.GridPedidos));
                HabilitaFornecedor_Simples();
                SelecFornecedor(GetValorColuna(2, this.GridPedidos));
                this.dtData.Value = Convert.ToDateTime(GetValorColuna(3, this.GridPedidos));
                this.txtTotalPedido.Text = "R$ " + String.Format("{0:0.00}", Convert.ToInt32(GetValorColuna(4, this.GridPedidos)));
                SelecEntregue(GetValorColuna(5, this.GridPedidos));
            }
        }

        private void SelecEntregue(string valor)
        {
            this.chEntregue.Checked = (valor.ToUpperInvariant().Equals("TRUE")) ? true : false;
        }

        private void HabilitaFuncionario_Simples()
        {
            this.txtFuncionario.Visible = true;
            this.cbFuncionario.Visible = false;
        }
        private void DesabilitaFuncionario_Simples()
        {
            this.txtFuncionario.Visible = false;
            this.cbFuncionario.Visible = true;
        }

        private void HabilitaFornecedor_Simples()
        {
            this.txtFornecedor.Visible = true;
            this.cbFornecedor.Visible = false;
        }
        private void DesabilitaFornecedor_Simples()
        {
            this.txtFornecedor.Visible = false;
            this.cbFornecedor.Visible = true;
        }

        private void HabilitaProduto_Simples()
        {
            this.txtProduto.Visible = true;
            this.cbProduto.Visible = false;
        }
        private void DesabilitaProduto_Simples()
        {
            this.txtProduto.Visible = false;
            this.cbProduto.Visible = true;
        }

        private void SelecFuncionario(string funcionario)
        {
            foreach (DataRowView item in this.cbFuncionario.Items.Cast<DataRowView>())
            {
                string str = item.Row[0].ToString();
                if (str.Equals(funcionario))
                {
                    this.cbFuncionario.SelectedIndex = this.cbFuncionario.Items.IndexOf(item);
                }
            }
        }

        private void SelecFornecedor(string fornecedor)
        {
            foreach (DataRowView item in this.cbFornecedor.Items.Cast<DataRowView>())
            {
                string str = item.Row[0].ToString();
                if (str.Equals(fornecedor))
                {
                    this.cbFornecedor.SelectedIndex = this.cbFornecedor.Items.IndexOf(item);
                }
            }
        }

        private void SelecProduto(string produto)
        {
            foreach (DataRowView item in this.cbProduto.Items.Cast<DataRowView>())
            {
                string str = item.Row[0].ToString();
                if (str.Equals(produto))
                {
                    this.cbProduto.SelectedIndex = this.cbProduto.Items.IndexOf(item);
                }
            }
        }

        private void HabilitaConsulta()
        {
            this.tabctrDados.Tag = true;
            SelecDetalhes();
            this.tabctrDados.Tag = null;
            this.pnStatusConsult.Visible = true;

            this.btnAddItem.Enabled = false;
            this.btnRemoveItem.Enabled = false;
        }

        private void DesabilitaConsulta()
        {
            this.pnStatusAdd.Visible = false;
            this.pnStatusAlt.Visible = false;
            this.pnStatusConsult.Visible = false;
            this.tabctrDados.Tag = null;

            this.btnAddItem.Enabled = true;
            this.btnRemoveItem.Enabled = true;
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
                    SelecFuncionario(this.txtFuncionario.Text);
                    SelecFornecedor(this.txtFornecedor.Text);
                    break;
            }
            this.btnCancelar.Enabled = true;

            DesabilitaFuncionario_Simples();
            DesabilitaFornecedor_Simples();
            dtData.Enabled = true;
            this.GridPedidos.Enabled = false;
            this.pnBarraFiltroPedido.Enabled = false;
            this.pnBarraFiltroPedido.BackColor = Color.Azure;

            this.txtQtdeSolicitada.ReadOnly = false;

            this.tabctrDados.Tag = true;
            SelecDetalhes();

            this.btnConsultar.Enabled = false;
            this.btnNovo.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnExcluir.Enabled = false;

            this.btnAddItem.Enabled = true;
        }

        private void DesabilitaEdicao()
        {
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Tag = null;
            this.pnStatusConsult.Visible = false;
            this.pnStatusAdd.Visible = false;
            this.pnStatusAlt.Visible = false;
            this.btnCancelar.Enabled = false;

            HabilitaFuncionario_Simples();
            HabilitaFornecedor_Simples();
            dtData.Enabled = false;
            this.GridPedidos.Enabled = true;
            this.pnBarraFiltroPedido.Enabled = true;
            this.pnBarraFiltroPedido.BackColor = Color.DarkTurquoise;

            SelecLista();
            this.tabctrDados.Tag = false;

            this.btnConsultar.Enabled = true;
            this.btnNovo.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnExcluir.Enabled = true;
        }

        private void LimparCampos()
        {
            this.txtFuncionario.Text = string.Empty;
            this.txtFornecedor.Text = string.Empty;
            this.dtData.Value = DateTime.Now;
            this.txtTotalPedido.Text = "R$ " + string.Format("{0:0.00}", 0);
            this.chEntregue.Checked = false;

            this.txtProduto.Text = string.Empty;
            this.txtQtdeSolicitada.Text = string.Empty;
            this.txtValor.Text = string.Format("{0:0.00}", 0);
            this.GridItens.Rows.Clear();
            this.GridItens.Columns.Clear();
        }

        private void SelecLista()
        {
            tabctrDados.SelectedIndex = 0;
        }

        private void SelecDetalhes()
        {
            tabctrDados.SelectedIndex = 1;
        }
        #endregion

        private void txtQtdeSolicitada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void ValidaAddProduto()
        {
            string msg = clsUtil.RetonarFuncaoEscalar(estoqueConnStr,
                "fnValidaAddItem_Pedido",
                this.cbProduto.SelectedValue.ToString(),
                GetValorColuna(0, this.GridPedidos),               
                this.txtQtdeSolicitada.Text)
                .ToString();
            string numMsg = msg.Split('|')[0];
            msg = msg.Split('|')[1];

            //MensagemAcao(msg, numMsg);

            if (!ExisteErro(numMsg))
            {
                string valor_prod = clsUtil.RetonarFuncaoEscalar(estoqueConnStr, "fnGetPreco_Produto", this.cbProduto.SelectedValue.ToString()).ToString();
                this.GridItens.Rows[this.GridItens.Rows.Count - 1].Selected = true;
                //AddProduto(itemsIn_DB, this.cbProduto.SelectedValue.ToString(), GetValorColuna(0, this.GridPedidos), this.txtQtdeSolicitada.Text, ((Convert.ToDouble(valor_prod) * Convert.ToInt32(this.txtQtdeSolicitada.Text)).ToString()));
                DesabilitaEdicao();
            }
        }

        private void AddProduto(string id, string id_produto, string id_pedido, string qtde_solicitada, string valor)
        {
            this.GridItens.Rows.Add(id, id_produto, id_pedido, qtde_solicitada, valor);
            this.itemsToInsert_DB.Rows.Add(this.GridItens.Rows[this.GridItens.Rows.Count - 1]);
        }

        private void MensagemAcao(string msg, string numMsg)
        {
            MessageBox.Show(msg, "Stock PC", MessageBoxButtons.OK, (!ExisteErro(numMsg)) ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private bool ExisteErro(string numMsg)
        {
            return (numMsg.Equals("1")) ? true : false;
        }
    }
}
