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
    public partial class wfRelFornecedor : Form
    {
        public wfRelFornecedor()
        {
            InitializeComponent();
        }

        private void wfRelFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet1.tbfornecedor' table. You can move, or remove it, as needed.
            this.tbfornecedorTableAdapter.Fill(this.estoqueDataSet1.tbfornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
