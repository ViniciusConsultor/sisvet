namespace StockPC
{
    partial class wfCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCadProduto));
            this.pnBarraFiltro = new System.Windows.Forms.Panel();
            this.cbCategoria_F = new System.Windows.Forms.ComboBox();
            this.lbCategoria_F = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtDescricao_F = new System.Windows.Forms.TextBox();
            this.lbDescricao_F = new System.Windows.Forms.Label();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.txtQtdeTotal = new System.Windows.Forms.TextBox();
            this.lbQtdeTotal = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lbValorVenda = new System.Windows.Forms.Label();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.lbValorCusto = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBarraPrincipal = new System.Windows.Forms.Panel();
            this.pnStatusAlt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnStatusAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnBarraFiltro.SuspendLayout();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.pnBarraPrincipal.SuspendLayout();
            this.pnStatusAlt.SuspendLayout();
            this.pnStatusAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBarraFiltro
            // 
            this.pnBarraFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBarraFiltro.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnBarraFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBarraFiltro.BackgroundImage")));
            this.pnBarraFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBarraFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBarraFiltro.Controls.Add(this.cbCategoria_F);
            this.pnBarraFiltro.Controls.Add(this.lbCategoria_F);
            this.pnBarraFiltro.Controls.Add(this.btnFiltrar);
            this.pnBarraFiltro.Controls.Add(this.txtDescricao_F);
            this.pnBarraFiltro.Controls.Add(this.lbDescricao_F);
            this.pnBarraFiltro.Location = new System.Drawing.Point(11, 153);
            this.pnBarraFiltro.Name = "pnBarraFiltro";
            this.pnBarraFiltro.Size = new System.Drawing.Size(778, 41);
            this.pnBarraFiltro.TabIndex = 44;
            // 
            // cbCategoria_F
            // 
            this.cbCategoria_F.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoria_F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCategoria_F.FormattingEnabled = true;
            this.cbCategoria_F.Location = new System.Drawing.Point(504, 10);
            this.cbCategoria_F.Name = "cbCategoria_F";
            this.cbCategoria_F.Size = new System.Drawing.Size(177, 21);
            this.cbCategoria_F.TabIndex = 43;
            // 
            // lbCategoria_F
            // 
            this.lbCategoria_F.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCategoria_F.AutoSize = true;
            this.lbCategoria_F.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoria_F.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria_F.Location = new System.Drawing.Point(420, 11);
            this.lbCategoria_F.Name = "lbCategoria_F";
            this.lbCategoria_F.Size = new System.Drawing.Size(78, 16);
            this.lbCategoria_F.TabIndex = 42;
            this.lbCategoria_F.Text = "Categoria:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(687, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(86, 33);
            this.btnFiltrar.TabIndex = 41;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtDescricao_F
            // 
            this.txtDescricao_F.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao_F.Location = new System.Drawing.Point(89, 10);
            this.txtDescricao_F.Name = "txtDescricao_F";
            this.txtDescricao_F.Size = new System.Drawing.Size(321, 20);
            this.txtDescricao_F.TabIndex = 36;
            // 
            // lbDescricao_F
            // 
            this.lbDescricao_F.AutoSize = true;
            this.lbDescricao_F.BackColor = System.Drawing.Color.Transparent;
            this.lbDescricao_F.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao_F.Location = new System.Drawing.Point(6, 11);
            this.lbDescricao_F.Name = "lbDescricao_F";
            this.lbDescricao_F.Size = new System.Drawing.Size(77, 16);
            this.lbDescricao_F.TabIndex = 35;
            this.lbDescricao_F.Text = "Descrição:";
            // 
            // gbDados
            // 
            this.gbDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDados.BackColor = System.Drawing.Color.Transparent;
            this.gbDados.Controls.Add(this.txtQtdeTotal);
            this.gbDados.Controls.Add(this.lbQtdeTotal);
            this.gbDados.Controls.Add(this.lbCategoria);
            this.gbDados.Controls.Add(this.txtValorVenda);
            this.gbDados.Controls.Add(this.lbValorVenda);
            this.gbDados.Controls.Add(this.txtValorCusto);
            this.gbDados.Controls.Add(this.lbValorCusto);
            this.gbDados.Controls.Add(this.txtDescricao);
            this.gbDados.Controls.Add(this.lbDescricao);
            this.gbDados.Controls.Add(this.cbCategoria);
            this.gbDados.Controls.Add(this.txtCategoria);
            this.gbDados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.Location = new System.Drawing.Point(11, 38);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(778, 109);
            this.gbDados.TabIndex = 43;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados do Produto";
            // 
            // txtQtdeTotal
            // 
            this.txtQtdeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeTotal.Location = new System.Drawing.Point(518, 51);
            this.txtQtdeTotal.Name = "txtQtdeTotal";
            this.txtQtdeTotal.ReadOnly = true;
            this.txtQtdeTotal.Size = new System.Drawing.Size(105, 20);
            this.txtQtdeTotal.TabIndex = 36;
            this.txtQtdeTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaInteiro_KeyPress);
            // 
            // lbQtdeTotal
            // 
            this.lbQtdeTotal.AutoSize = true;
            this.lbQtdeTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdeTotal.Location = new System.Drawing.Point(429, 52);
            this.lbQtdeTotal.Name = "lbQtdeTotal";
            this.lbQtdeTotal.Size = new System.Drawing.Size(83, 16);
            this.lbQtdeTotal.TabIndex = 35;
            this.lbQtdeTotal.Text = "Qtde. Total:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(23, 78);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(78, 16);
            this.lbCategoria.TabIndex = 28;
            this.lbCategoria.Text = "Categoria:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(318, 51);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.ReadOnly = true;
            this.txtValorVenda.Size = new System.Drawing.Size(105, 20);
            this.txtValorVenda.TabIndex = 27;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaInteiro_KeyPress);
            // 
            // lbValorVenda
            // 
            this.lbValorVenda.AutoSize = true;
            this.lbValorVenda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorVenda.Location = new System.Drawing.Point(218, 52);
            this.lbValorVenda.Name = "lbValorVenda";
            this.lbValorVenda.Size = new System.Drawing.Size(94, 16);
            this.lbValorVenda.TabIndex = 26;
            this.lbValorVenda.Text = "Valor Venda:";
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCusto.Location = new System.Drawing.Point(107, 51);
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.ReadOnly = true;
            this.txtValorCusto.Size = new System.Drawing.Size(105, 20);
            this.txtValorCusto.TabIndex = 21;
            this.txtValorCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaInteiro_KeyPress);
            // 
            // lbValorCusto
            // 
            this.lbValorCusto.AutoSize = true;
            this.lbValorCusto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorCusto.Location = new System.Drawing.Point(14, 52);
            this.lbValorCusto.Name = "lbValorCusto";
            this.lbValorCusto.Size = new System.Drawing.Size(87, 16);
            this.lbValorCusto.TabIndex = 20;
            this.lbValorCusto.Text = "Valor Custo:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(107, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(665, 20);
            this.txtDescricao.TabIndex = 12;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(24, 26);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(77, 16);
            this.lbDescricao.TabIndex = 11;
            this.lbDescricao.Text = "Descrição:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(107, 77);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(205, 21);
            this.cbCategoria.TabIndex = 34;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(107, 77);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(105, 20);
            this.txtCategoria.TabIndex = 37;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Valor_Custo,
            this.Valor_Venda,
            this.QtdeTotal,
            this.Categoria});
            this.Grid.Location = new System.Drawing.Point(11, 193);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(778, 205);
            this.Grid.TabIndex = 42;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Valor_Custo
            // 
            this.Valor_Custo.HeaderText = "Valor Custo";
            this.Valor_Custo.Name = "Valor_Custo";
            // 
            // Valor_Venda
            // 
            this.Valor_Venda.HeaderText = "Valor Renda";
            this.Valor_Venda.Name = "Valor_Venda";
            // 
            // QtdeTotal
            // 
            this.QtdeTotal.HeaderText = "Qdte. Total";
            this.QtdeTotal.Name = "QtdeTotal";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // pnBarraPrincipal
            // 
            this.pnBarraPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBarraPrincipal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnBarraPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBarraPrincipal.BackgroundImage")));
            this.pnBarraPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBarraPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pnBarraPrincipal.Size = new System.Drawing.Size(796, 30);
            this.pnBarraPrincipal.TabIndex = 41;
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
            this.pnStatusAlt.Location = new System.Drawing.Point(686, -1);
            this.pnStatusAlt.Name = "pnStatusAlt";
            this.pnStatusAlt.Size = new System.Drawing.Size(109, 30);
            this.pnStatusAlt.TabIndex = 60;
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
            this.pnStatusAdd.Location = new System.Drawing.Point(686, -1);
            this.pnStatusAdd.Name = "pnStatusAdd";
            this.pnStatusAdd.Size = new System.Drawing.Size(109, 30);
            this.pnStatusAdd.TabIndex = 59;
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(184, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(135, 3);
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
            this.btnExcluir.Location = new System.Drawing.Point(93, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(36, 28);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(142, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 28);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(51, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 28);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(9, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(36, 28);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // wfCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.pnBarraFiltro);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.pnBarraPrincipal);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(816, 449);
            this.Name = "wfCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.wfCadProduto_Load);
            this.pnBarraFiltro.ResumeLayout(false);
            this.pnBarraFiltro.PerformLayout();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.pnBarraPrincipal.ResumeLayout(false);
            this.pnStatusAlt.ResumeLayout(false);
            this.pnStatusAlt.PerformLayout();
            this.pnStatusAdd.ResumeLayout(false);
            this.pnStatusAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBarraFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtDescricao_F;
        private System.Windows.Forms.Label lbDescricao_F;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lbValorVenda;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.Label lbValorCusto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel pnBarraPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtQtdeTotal;
        private System.Windows.Forms.Label lbQtdeTotal;
        private System.Windows.Forms.ComboBox cbCategoria_F;
        private System.Windows.Forms.Label lbCategoria_F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Panel pnStatusAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnStatusAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}