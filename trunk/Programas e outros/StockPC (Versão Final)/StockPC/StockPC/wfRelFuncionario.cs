﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockPC
{
    public partial class wfRelFuncionario : Form
    {
        public wfRelFuncionario()
        {
            InitializeComponent();
        }

        private void wfRelFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet1.tbfuncionario' table. You can move, or remove it, as needed.
            this.tbfuncionarioTableAdapter.Fill(this.estoqueDataSet1.tbfuncionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
