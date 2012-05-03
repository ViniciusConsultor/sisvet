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
    public partial class wfRelCategoria : Form
    {
        public wfRelCategoria()
        {
            InitializeComponent();
        }

        private void wfRepCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet.tbcategoria' table. You can move, or remove it, as needed.
            this.tbcategoriaTableAdapter.Fill(this.estoqueDataSet.tbcategoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
