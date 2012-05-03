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
    public partial class wfRelProduto : Form
    {
        public wfRelProduto()
        {
            InitializeComponent();
        }

        private void wfRelProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet1.tbproduto' table. You can move, or remove it, as needed.
            this.tbprodutoTableAdapter.Fill(this.estoqueDataSet1.tbproduto);

            this.reportViewer1.RefreshReport();
        }
    }
}
