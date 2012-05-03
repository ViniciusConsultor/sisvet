namespace StockPC
{
    partial class wfCadCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCadCategoria));
            this.pnBarraFiltro = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtNome_F = new System.Windows.Forms.TextBox();
            this.lbNome_F = new System.Windows.Forms.Label();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBarraPrincipal = new System.Windows.Forms.Panel();
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
            this.pnBarraFiltro.Controls.Add(this.btnFiltrar);
            this.pnBarraFiltro.Controls.Add(this.txtNome_F);
            this.pnBarraFiltro.Controls.Add(this.lbNome_F);
            this.pnBarraFiltro.Location = new System.Drawing.Point(11, 121);
            this.pnBarraFiltro.Name = "pnBarraFiltro";
            this.pnBarraFiltro.Size = new System.Drawing.Size(538, 41);
            this.pnBarraFiltro.TabIndex = 44;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(447, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(86, 33);
            this.btnFiltrar.TabIndex = 41;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtNome_F
            // 
            this.txtNome_F.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome_F.Location = new System.Drawing.Point(62, 10);
            this.txtNome_F.Name = "txtNome_F";
            this.txtNome_F.Size = new System.Drawing.Size(379, 20);
            this.txtNome_F.TabIndex = 36;
            // 
            // lbNome_F
            // 
            this.lbNome_F.AutoSize = true;
            this.lbNome_F.BackColor = System.Drawing.Color.Transparent;
            this.lbNome_F.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome_F.Location = new System.Drawing.Point(6, 11);
            this.lbNome_F.Name = "lbNome_F";
            this.lbNome_F.Size = new System.Drawing.Size(50, 16);
            this.lbNome_F.TabIndex = 35;
            this.lbNome_F.Text = "Nome:";
            // 
            // gbDados
            // 
            this.gbDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDados.BackColor = System.Drawing.Color.Transparent;
            this.gbDados.Controls.Add(this.txtDescricao);
            this.gbDados.Controls.Add(this.lbDescricao);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.lbNome);
            this.gbDados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.Location = new System.Drawing.Point(11, 38);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(538, 77);
            this.gbDados.TabIndex = 43;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados da Categoria";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(90, 46);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(442, 20);
            this.txtDescricao.TabIndex = 21;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(7, 47);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(77, 16);
            this.lbDescricao.TabIndex = 20;
            this.lbDescricao.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(90, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(442, 20);
            this.txtNome.TabIndex = 12;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(34, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(50, 16);
            this.lbNome.TabIndex = 11;
            this.lbNome.Text = "Nome:";
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
            this.Nome,
            this.Descricao});
            this.Grid.Location = new System.Drawing.Point(11, 161);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(538, 205);
            this.Grid.TabIndex = 42;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
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
            this.pnBarraPrincipal.Size = new System.Drawing.Size(555, 30);
            this.pnBarraPrincipal.TabIndex = 41;
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
            // pnStatusAlt
            // 
            this.pnStatusAlt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStatusAlt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnStatusAlt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnStatusAlt.BackgroundImage")));
            this.pnStatusAlt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnStatusAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStatusAlt.Controls.Add(this.label2);
            this.pnStatusAlt.Location = new System.Drawing.Point(445, -1);
            this.pnStatusAlt.Name = "pnStatusAlt";
            this.pnStatusAlt.Size = new System.Drawing.Size(109, 30);
            this.pnStatusAlt.TabIndex = 54;
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
            this.pnStatusAdd.Location = new System.Drawing.Point(445, -1);
            this.pnStatusAdd.Name = "pnStatusAdd";
            this.pnStatusAdd.Size = new System.Drawing.Size(109, 30);
            this.pnStatusAdd.TabIndex = 53;
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
            // wfCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 378);
            this.Controls.Add(this.pnBarraFiltro);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.pnBarraPrincipal);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(575, 416);
            this.Name = "wfCadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias";
            this.Load += new System.EventHandler(this.wfCadCategoria_Load);
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
        private System.Windows.Forms.TextBox txtNome_F;
        private System.Windows.Forms.Label lbNome_F;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel pnBarraPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.Panel pnStatusAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnStatusAlt;
        private System.Windows.Forms.Label label2;
    }
}