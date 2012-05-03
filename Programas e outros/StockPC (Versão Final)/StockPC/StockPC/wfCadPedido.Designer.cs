namespace StockPC
{
    partial class wfCadPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCadPedido));
            this.pnBarraFiltroPedido = new System.Windows.Forms.Panel();
            this.cbFornecedor_F = new System.Windows.Forms.ComboBox();
            this.cbSituacao_F = new System.Windows.Forms.ComboBox();
            this.lbSituacao_F = new System.Windows.Forms.Label();
            this.dtData_F = new System.Windows.Forms.DateTimePicker();
            this.lbData_F = new System.Windows.Forms.Label();
            this.lbFornecedor_F = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.chEntregue = new System.Windows.Forms.CheckBox();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.lbTotalPedido = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.GridPedidos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Entregue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnBarraPrincipal = new System.Windows.Forms.Panel();
            this.pnStatusConsult = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnStatusAlt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnStatusAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabctrDados = new System.Windows.Forms.TabControl();
            this.tabpgLista = new System.Windows.Forms.TabPage();
            this.tabpgDetalhes = new System.Windows.Forms.TabPage();
            this.gbDadosItens = new System.Windows.Forms.GroupBox();
            this.btnClearItens = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pbBarraFiltroItem = new System.Windows.Forms.Panel();
            this.cbProduto_F = new System.Windows.Forms.ComboBox();
            this.lbProduto_FI = new System.Windows.Forms.Label();
            this.btnFiltrarItem = new System.Windows.Forms.Button();
            this.GridItens = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde_Solicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baixa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde_Comprada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.txtQtdeSolicitada = new System.Windows.Forms.TextBox();
            this.lbQtdeSolicitada = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.pnBarraFiltroPedido.SuspendLayout();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).BeginInit();
            this.pnBarraPrincipal.SuspendLayout();
            this.pnStatusConsult.SuspendLayout();
            this.pnStatusAlt.SuspendLayout();
            this.pnStatusAdd.SuspendLayout();
            this.tabctrDados.SuspendLayout();
            this.tabpgLista.SuspendLayout();
            this.tabpgDetalhes.SuspendLayout();
            this.gbDadosItens.SuspendLayout();
            this.pbBarraFiltroItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBarraFiltroPedido
            // 
            this.pnBarraFiltroPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBarraFiltroPedido.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnBarraFiltroPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBarraFiltroPedido.BackgroundImage")));
            this.pnBarraFiltroPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBarraFiltroPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBarraFiltroPedido.Controls.Add(this.cbFornecedor_F);
            this.pnBarraFiltroPedido.Controls.Add(this.cbSituacao_F);
            this.pnBarraFiltroPedido.Controls.Add(this.lbSituacao_F);
            this.pnBarraFiltroPedido.Controls.Add(this.dtData_F);
            this.pnBarraFiltroPedido.Controls.Add(this.lbData_F);
            this.pnBarraFiltroPedido.Controls.Add(this.lbFornecedor_F);
            this.pnBarraFiltroPedido.Controls.Add(this.btnFiltrar);
            this.pnBarraFiltroPedido.Location = new System.Drawing.Point(6, 6);
            this.pnBarraFiltroPedido.Name = "pnBarraFiltroPedido";
            this.pnBarraFiltroPedido.Size = new System.Drawing.Size(911, 41);
            this.pnBarraFiltroPedido.TabIndex = 40;
            // 
            // cbFornecedor_F
            // 
            this.cbFornecedor_F.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFornecedor_F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbFornecedor_F.FormattingEnabled = true;
            this.cbFornecedor_F.Location = new System.Drawing.Point(101, 10);
            this.cbFornecedor_F.Name = "cbFornecedor_F";
            this.cbFornecedor_F.Size = new System.Drawing.Size(337, 21);
            this.cbFornecedor_F.TabIndex = 47;
            // 
            // cbSituacao_F
            // 
            this.cbSituacao_F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao_F.FormattingEnabled = true;
            this.cbSituacao_F.Location = new System.Drawing.Point(673, 9);
            this.cbSituacao_F.Name = "cbSituacao_F";
            this.cbSituacao_F.Size = new System.Drawing.Size(136, 21);
            this.cbSituacao_F.TabIndex = 41;
            // 
            // lbSituacao_F
            // 
            this.lbSituacao_F.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSituacao_F.AutoSize = true;
            this.lbSituacao_F.BackColor = System.Drawing.Color.Transparent;
            this.lbSituacao_F.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacao_F.Location = new System.Drawing.Point(598, 11);
            this.lbSituacao_F.Name = "lbSituacao_F";
            this.lbSituacao_F.Size = new System.Drawing.Size(69, 16);
            this.lbSituacao_F.TabIndex = 46;
            this.lbSituacao_F.Text = "Situação:";
            // 
            // dtData_F
            // 
            this.dtData_F.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData_F.Location = new System.Drawing.Point(493, 10);
            this.dtData_F.Name = "dtData_F";
            this.dtData_F.Size = new System.Drawing.Size(99, 20);
            this.dtData_F.TabIndex = 41;
            // 
            // lbData_F
            // 
            this.lbData_F.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData_F.AutoSize = true;
            this.lbData_F.BackColor = System.Drawing.Color.Transparent;
            this.lbData_F.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData_F.Location = new System.Drawing.Point(444, 11);
            this.lbData_F.Name = "lbData_F";
            this.lbData_F.Size = new System.Drawing.Size(43, 16);
            this.lbData_F.TabIndex = 45;
            this.lbData_F.Text = "Data:";
            // 
            // lbFornecedor_F
            // 
            this.lbFornecedor_F.AutoSize = true;
            this.lbFornecedor_F.BackColor = System.Drawing.Color.Transparent;
            this.lbFornecedor_F.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFornecedor_F.Location = new System.Drawing.Point(10, 11);
            this.lbFornecedor_F.Name = "lbFornecedor_F";
            this.lbFornecedor_F.Size = new System.Drawing.Size(85, 16);
            this.lbFornecedor_F.TabIndex = 42;
            this.lbFornecedor_F.Text = "Fornecedor:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(815, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(91, 33);
            this.btnFiltrar.TabIndex = 41;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // gbDados
            // 
            this.gbDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDados.BackColor = System.Drawing.Color.Transparent;
            this.gbDados.Controls.Add(this.dtData);
            this.gbDados.Controls.Add(this.chEntregue);
            this.gbDados.Controls.Add(this.lbFornecedor);
            this.gbDados.Controls.Add(this.txtTotalPedido);
            this.gbDados.Controls.Add(this.lbTotalPedido);
            this.gbDados.Controls.Add(this.lbData);
            this.gbDados.Controls.Add(this.lbFuncionario);
            this.gbDados.Controls.Add(this.cbFuncionario);
            this.gbDados.Controls.Add(this.cbFornecedor);
            this.gbDados.Controls.Add(this.txtFornecedor);
            this.gbDados.Controls.Add(this.txtFuncionario);
            this.gbDados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.Location = new System.Drawing.Point(6, 8);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(911, 81);
            this.gbDados.TabIndex = 39;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados do Pedido";
            // 
            // dtData
            // 
            this.dtData.Enabled = false;
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(105, 47);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(99, 21);
            this.dtData.TabIndex = 42;
            // 
            // chEntregue
            // 
            this.chEntregue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chEntregue.AutoSize = true;
            this.chEntregue.Enabled = false;
            this.chEntregue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chEntregue.Location = new System.Drawing.Point(549, 47);
            this.chEntregue.Name = "chEntregue";
            this.chEntregue.Size = new System.Drawing.Size(78, 20);
            this.chEntregue.TabIndex = 38;
            this.chEntregue.Text = "Entregue";
            this.chEntregue.UseVisualStyleBackColor = true;
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFornecedor.Location = new System.Drawing.Point(463, 21);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(85, 16);
            this.lbFornecedor.TabIndex = 36;
            this.lbFornecedor.Text = "Fornecedor:";
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPedido.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotalPedido.Location = new System.Drawing.Point(308, 45);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.ReadOnly = true;
            this.txtTotalPedido.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPedido.TabIndex = 21;
            this.txtTotalPedido.Text = "0";
            // 
            // lbTotalPedido
            // 
            this.lbTotalPedido.AutoSize = true;
            this.lbTotalPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPedido.Location = new System.Drawing.Point(210, 48);
            this.lbTotalPedido.Name = "lbTotalPedido";
            this.lbTotalPedido.Size = new System.Drawing.Size(92, 16);
            this.lbTotalPedido.TabIndex = 20;
            this.lbTotalPedido.Text = "Total Pedido:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(56, 48);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(43, 16);
            this.lbData.TabIndex = 14;
            this.lbData.Text = "Data:";
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncionario.Location = new System.Drawing.Point(11, 21);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(88, 16);
            this.lbFuncionario.TabIndex = 11;
            this.lbFuncionario.Text = "Funcionário:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(105, 19);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(352, 21);
            this.cbFuncionario.TabIndex = 35;
            this.cbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbFuncionario_SelectedIndexChanged);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(549, 19);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(356, 21);
            this.cbFornecedor.TabIndex = 37;
            this.cbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbFornecedor_SelectedIndexChanged);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(549, 19);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(356, 21);
            this.txtFornecedor.TabIndex = 44;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(105, 19);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.Size = new System.Drawing.Size(352, 21);
            this.txtFuncionario.TabIndex = 43;
            // 
            // GridPedidos
            // 
            this.GridPedidos.AllowUserToAddRows = false;
            this.GridPedidos.AllowUserToDeleteRows = false;
            this.GridPedidos.AllowUserToOrderColumns = true;
            this.GridPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Funcionario,
            this.Fornecedor,
            this.Data,
            this.Total_Pedido,
            this.Autorizado,
            this.Entregue});
            this.GridPedidos.Location = new System.Drawing.Point(6, 45);
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPedidos.Size = new System.Drawing.Size(911, 327);
            this.GridPedidos.TabIndex = 38;
            this.GridPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPedidos_CellDoubleClick);
            this.GridPedidos.SelectionChanged += new System.EventHandler(this.GridPedidos_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Funcionario
            // 
            this.Funcionario.HeaderText = "Funionário";
            this.Funcionario.Name = "Funcionario";
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Total_Pedido
            // 
            this.Total_Pedido.HeaderText = "Total Pedido";
            this.Total_Pedido.Name = "Total_Pedido";
            // 
            // Autorizado
            // 
            this.Autorizado.HeaderText = "Autorizado";
            this.Autorizado.Name = "Autorizado";
            // 
            // Entregue
            // 
            this.Entregue.HeaderText = "Entregue";
            this.Entregue.Name = "Entregue";
            // 
            // pnBarraPrincipal
            // 
            this.pnBarraPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBarraPrincipal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnBarraPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBarraPrincipal.BackgroundImage")));
            this.pnBarraPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBarraPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBarraPrincipal.Controls.Add(this.pnStatusConsult);
            this.pnBarraPrincipal.Controls.Add(this.btnConsultar);
            this.pnBarraPrincipal.Controls.Add(this.btnCancelar);
            this.pnBarraPrincipal.Controls.Add(this.panel2);
            this.pnBarraPrincipal.Controls.Add(this.btnExcluir);
            this.pnBarraPrincipal.Controls.Add(this.btnSalvar);
            this.pnBarraPrincipal.Controls.Add(this.btnEditar);
            this.pnBarraPrincipal.Controls.Add(this.btnNovo);
            this.pnBarraPrincipal.Controls.Add(this.pnStatusAlt);
            this.pnBarraPrincipal.Controls.Add(this.pnStatusAdd);
            this.pnBarraPrincipal.Location = new System.Drawing.Point(2, 2);
            this.pnBarraPrincipal.Name = "pnBarraPrincipal";
            this.pnBarraPrincipal.Size = new System.Drawing.Size(950, 30);
            this.pnBarraPrincipal.TabIndex = 37;
            // 
            // pnStatusConsult
            // 
            this.pnStatusConsult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStatusConsult.BackColor = System.Drawing.Color.Silver;
            this.pnStatusConsult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnStatusConsult.BackgroundImage")));
            this.pnStatusConsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnStatusConsult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStatusConsult.Controls.Add(this.label3);
            this.pnStatusConsult.Location = new System.Drawing.Point(840, -1);
            this.pnStatusConsult.Name = "pnStatusConsult";
            this.pnStatusConsult.Size = new System.Drawing.Size(109, 30);
            this.pnStatusConsult.TabIndex = 62;
            this.pnStatusConsult.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consultando";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(3, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(36, 28);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(220, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(171, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 23);
            this.panel2.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(129, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(36, 28);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(178, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 28);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(87, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 28);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(45, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(36, 28);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnStatusAlt
            // 
            this.pnStatusAlt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStatusAlt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnStatusAlt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnStatusAlt.BackgroundImage")));
            this.pnStatusAlt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnStatusAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStatusAlt.Controls.Add(this.label2);
            this.pnStatusAlt.Location = new System.Drawing.Point(840, -1);
            this.pnStatusAlt.Name = "pnStatusAlt";
            this.pnStatusAlt.Size = new System.Drawing.Size(109, 30);
            this.pnStatusAlt.TabIndex = 64;
            this.pnStatusAlt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alterando";
            // 
            // pnStatusAdd
            // 
            this.pnStatusAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStatusAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnStatusAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnStatusAdd.BackgroundImage")));
            this.pnStatusAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnStatusAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStatusAdd.Controls.Add(this.label1);
            this.pnStatusAdd.Location = new System.Drawing.Point(840, -1);
            this.pnStatusAdd.Name = "pnStatusAdd";
            this.pnStatusAdd.Size = new System.Drawing.Size(109, 30);
            this.pnStatusAdd.TabIndex = 63;
            this.pnStatusAdd.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adicionando";
            // 
            // tabctrDados
            // 
            this.tabctrDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrDados.Controls.Add(this.tabpgLista);
            this.tabctrDados.Controls.Add(this.tabpgDetalhes);
            this.tabctrDados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrDados.Location = new System.Drawing.Point(12, 38);
            this.tabctrDados.Name = "tabctrDados";
            this.tabctrDados.SelectedIndex = 0;
            this.tabctrDados.Size = new System.Drawing.Size(931, 410);
            this.tabctrDados.TabIndex = 42;
            this.tabctrDados.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabctrDados_Selected);
            // 
            // tabpgLista
            // 
            this.tabpgLista.BackColor = System.Drawing.Color.PowderBlue;
            this.tabpgLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabpgLista.BackgroundImage")));
            this.tabpgLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabpgLista.Controls.Add(this.pnBarraFiltroPedido);
            this.tabpgLista.Controls.Add(this.GridPedidos);
            this.tabpgLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabpgLista.Location = new System.Drawing.Point(4, 28);
            this.tabpgLista.Name = "tabpgLista";
            this.tabpgLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgLista.Size = new System.Drawing.Size(923, 378);
            this.tabpgLista.TabIndex = 0;
            this.tabpgLista.Text = "Lista";
            // 
            // tabpgDetalhes
            // 
            this.tabpgDetalhes.BackColor = System.Drawing.Color.PowderBlue;
            this.tabpgDetalhes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabpgDetalhes.BackgroundImage")));
            this.tabpgDetalhes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabpgDetalhes.Controls.Add(this.gbDadosItens);
            this.tabpgDetalhes.Controls.Add(this.gbDados);
            this.tabpgDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabpgDetalhes.Location = new System.Drawing.Point(4, 28);
            this.tabpgDetalhes.Name = "tabpgDetalhes";
            this.tabpgDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgDetalhes.Size = new System.Drawing.Size(923, 378);
            this.tabpgDetalhes.TabIndex = 1;
            this.tabpgDetalhes.Text = "Detalhes";
            // 
            // gbDadosItens
            // 
            this.gbDadosItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosItens.BackColor = System.Drawing.Color.Transparent;
            this.gbDadosItens.Controls.Add(this.btnClearItens);
            this.gbDadosItens.Controls.Add(this.txtValor);
            this.gbDadosItens.Controls.Add(this.lbValor);
            this.gbDadosItens.Controls.Add(this.btnRemoveItem);
            this.gbDadosItens.Controls.Add(this.btnAddItem);
            this.gbDadosItens.Controls.Add(this.pbBarraFiltroItem);
            this.gbDadosItens.Controls.Add(this.GridItens);
            this.gbDadosItens.Controls.Add(this.cbProduto);
            this.gbDadosItens.Controls.Add(this.txtQtdeSolicitada);
            this.gbDadosItens.Controls.Add(this.lbQtdeSolicitada);
            this.gbDadosItens.Controls.Add(this.lbProduto);
            this.gbDadosItens.Controls.Add(this.txtProduto);
            this.gbDadosItens.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosItens.Location = new System.Drawing.Point(6, 95);
            this.gbDadosItens.Name = "gbDadosItens";
            this.gbDadosItens.Size = new System.Drawing.Size(911, 277);
            this.gbDadosItens.TabIndex = 40;
            this.gbDadosItens.TabStop = false;
            this.gbDadosItens.Text = "Itens do Pedido";
            // 
            // btnClearItens
            // 
            this.btnClearItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearItens.BackColor = System.Drawing.Color.Transparent;
            this.btnClearItens.FlatAppearance.BorderSize = 0;
            this.btnClearItens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnClearItens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClearItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearItens.Image = ((System.Drawing.Image)(resources.GetObject("btnClearItens.Image")));
            this.btnClearItens.Location = new System.Drawing.Point(858, 133);
            this.btnClearItens.Name = "btnClearItens";
            this.btnClearItens.Size = new System.Drawing.Size(42, 37);
            this.btnClearItens.TabIndex = 47;
            this.btnClearItens.UseVisualStyleBackColor = false;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.BackColor = System.Drawing.SystemColors.Info;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtValor.Location = new System.Drawing.Point(599, 18);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 46;
            this.txtValor.Text = "0";
            // 
            // lbValor
            // 
            this.lbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(546, 21);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(47, 16);
            this.lbValor.TabIndex = 45;
            this.lbValor.Text = "Valor:";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Image")));
            this.btnRemoveItem.Location = new System.Drawing.Point(858, 90);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(42, 37);
            this.btnRemoveItem.TabIndex = 43;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(858, 47);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(42, 37);
            this.btnAddItem.TabIndex = 42;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // pbBarraFiltroItem
            // 
            this.pbBarraFiltroItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBarraFiltroItem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pbBarraFiltroItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBarraFiltroItem.BackgroundImage")));
            this.pbBarraFiltroItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBarraFiltroItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBarraFiltroItem.Controls.Add(this.cbProduto_F);
            this.pbBarraFiltroItem.Controls.Add(this.lbProduto_FI);
            this.pbBarraFiltroItem.Controls.Add(this.btnFiltrarItem);
            this.pbBarraFiltroItem.Location = new System.Drawing.Point(6, 47);
            this.pbBarraFiltroItem.Name = "pbBarraFiltroItem";
            this.pbBarraFiltroItem.Size = new System.Drawing.Size(846, 41);
            this.pbBarraFiltroItem.TabIndex = 42;
            // 
            // cbProduto_F
            // 
            this.cbProduto_F.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProduto_F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbProduto_F.FormattingEnabled = true;
            this.cbProduto_F.Location = new System.Drawing.Point(67, 10);
            this.cbProduto_F.Name = "cbProduto_F";
            this.cbProduto_F.Size = new System.Drawing.Size(682, 21);
            this.cbProduto_F.TabIndex = 43;
            // 
            // lbProduto_FI
            // 
            this.lbProduto_FI.AutoSize = true;
            this.lbProduto_FI.BackColor = System.Drawing.Color.Transparent;
            this.lbProduto_FI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto_FI.Location = new System.Drawing.Point(4, 11);
            this.lbProduto_FI.Name = "lbProduto_FI";
            this.lbProduto_FI.Size = new System.Drawing.Size(61, 16);
            this.lbProduto_FI.TabIndex = 42;
            this.lbProduto_FI.Text = "Produto:";
            // 
            // btnFiltrarItem
            // 
            this.btnFiltrarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrarItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarItem.Location = new System.Drawing.Point(755, 3);
            this.btnFiltrarItem.Name = "btnFiltrarItem";
            this.btnFiltrarItem.Size = new System.Drawing.Size(86, 33);
            this.btnFiltrarItem.TabIndex = 41;
            this.btnFiltrarItem.Text = "Filtrar";
            this.btnFiltrarItem.UseVisualStyleBackColor = true;
            // 
            // GridItens
            // 
            this.GridItens.AllowUserToAddRows = false;
            this.GridItens.AllowUserToDeleteRows = false;
            this.GridItens.AllowUserToOrderColumns = true;
            this.GridItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Produto,
            this.Qtde_Solicitada,
            this.Baixa,
            this.Valor,
            this.Qtde_Comprada});
            this.GridItens.Location = new System.Drawing.Point(6, 86);
            this.GridItens.Name = "GridItens";
            this.GridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItens.Size = new System.Drawing.Size(846, 185);
            this.GridItens.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Qtde_Solicitada
            // 
            this.Qtde_Solicitada.HeaderText = "Qtde. Solicitada";
            this.Qtde_Solicitada.Name = "Qtde_Solicitada";
            // 
            // Baixa
            // 
            this.Baixa.HeaderText = "Baixa";
            this.Baixa.Name = "Baixa";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Qtde_Comprada
            // 
            this.Qtde_Comprada.HeaderText = "Qtde. Comprada";
            this.Qtde_Comprada.Name = "Qtde_Comprada";
            // 
            // cbProduto
            // 
            this.cbProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(78, 20);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(277, 21);
            this.cbProduto.TabIndex = 35;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            // 
            // txtQtdeSolicitada
            // 
            this.txtQtdeSolicitada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdeSolicitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeSolicitada.Location = new System.Drawing.Point(477, 20);
            this.txtQtdeSolicitada.Name = "txtQtdeSolicitada";
            this.txtQtdeSolicitada.ReadOnly = true;
            this.txtQtdeSolicitada.Size = new System.Drawing.Size(63, 20);
            this.txtQtdeSolicitada.TabIndex = 21;
            this.txtQtdeSolicitada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeSolicitada_KeyPress);
            // 
            // lbQtdeSolicitada
            // 
            this.lbQtdeSolicitada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQtdeSolicitada.AutoSize = true;
            this.lbQtdeSolicitada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdeSolicitada.Location = new System.Drawing.Point(361, 21);
            this.lbQtdeSolicitada.Name = "lbQtdeSolicitada";
            this.lbQtdeSolicitada.Size = new System.Drawing.Size(110, 16);
            this.lbQtdeSolicitada.TabIndex = 20;
            this.lbQtdeSolicitada.Text = "Qtd. Solicitada:";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.Location = new System.Drawing.Point(11, 21);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(61, 16);
            this.lbProduto.TabIndex = 11;
            this.lbProduto.Text = "Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(78, 20);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(277, 21);
            this.txtProduto.TabIndex = 48;
            // 
            // wfCadPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 460);
            this.Controls.Add(this.tabctrDados);
            this.Controls.Add(this.pnBarraPrincipal);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(971, 498);
            this.Name = "wfCadPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.Load += new System.EventHandler(this.wfCadPedido_Load);
            this.pnBarraFiltroPedido.ResumeLayout(false);
            this.pnBarraFiltroPedido.PerformLayout();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).EndInit();
            this.pnBarraPrincipal.ResumeLayout(false);
            this.pnStatusConsult.ResumeLayout(false);
            this.pnStatusConsult.PerformLayout();
            this.pnStatusAlt.ResumeLayout(false);
            this.pnStatusAlt.PerformLayout();
            this.pnStatusAdd.ResumeLayout(false);
            this.pnStatusAdd.PerformLayout();
            this.tabctrDados.ResumeLayout(false);
            this.tabpgLista.ResumeLayout(false);
            this.tabpgDetalhes.ResumeLayout(false);
            this.gbDadosItens.ResumeLayout(false);
            this.gbDadosItens.PerformLayout();
            this.pbBarraFiltroItem.ResumeLayout(false);
            this.pbBarraFiltroItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBarraFiltroPedido;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lbTotalPedido;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.DataGridView GridPedidos;
        private System.Windows.Forms.Panel pnBarraPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.CheckBox chEntregue;
        private System.Windows.Forms.Label lbData_F;
        private System.Windows.Forms.Label lbFornecedor_F;
        private System.Windows.Forms.TabControl tabctrDados;
        private System.Windows.Forms.TabPage tabpgLista;
        private System.Windows.Forms.TabPage tabpgDetalhes;
        private System.Windows.Forms.GroupBox gbDadosItens;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.TextBox txtQtdeSolicitada;
        private System.Windows.Forms.Label lbQtdeSolicitada;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Panel pbBarraFiltroItem;
        private System.Windows.Forms.Button btnFiltrarItem;
        private System.Windows.Forms.DataGridView GridItens;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lbProduto_FI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Pedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autorizado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Entregue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde_Solicitada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Baixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde_Comprada;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.ComboBox cbProduto_F;
        private System.Windows.Forms.DateTimePicker dtData_F;
        private System.Windows.Forms.Label lbSituacao_F;
        private System.Windows.Forms.ComboBox cbSituacao_F;
        private System.Windows.Forms.ComboBox cbFornecedor_F;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.TextBox txtTotalPedido;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Panel pnStatusConsult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnStatusAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnStatusAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearItens;
        private System.Windows.Forms.TextBox txtProduto;
    }
}