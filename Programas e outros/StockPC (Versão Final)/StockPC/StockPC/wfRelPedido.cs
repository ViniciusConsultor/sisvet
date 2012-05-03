using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace StockPC
{
    public partial class wfRelPedido : Form
    {
        public wfRelPedido()
        {
            InitializeComponent();
        }

        private void wfRelPedido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet1.tbpedido' table. You can move, or remove it, as needed.
            this.tbpedidoTableAdapter.Fill(this.estoqueDataSet1.tbpedido);

            this.reportViewer1.RefreshReport();
        }
    }
}
