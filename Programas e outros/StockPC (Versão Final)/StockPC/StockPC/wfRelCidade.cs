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
    public partial class wfRelCidade : Form
    {
        public wfRelCidade()
        {
            InitializeComponent();
        }

        private void wfRelCidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet1.tbcidade' table. You can move, or remove it, as needed.
            this.tbcidadeTableAdapter.Fill(this.estoqueDataSet1.tbcidade);

            this.reportViewer1.RefreshReport();
        }
    }
}
