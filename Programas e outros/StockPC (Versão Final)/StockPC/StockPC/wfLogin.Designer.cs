namespace StockPC
{
    partial class wfLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfLogin));
            this.gbDadosLogin = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mtxtSenha = new System.Windows.Forms.MaskedTextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.gbDadosLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosLogin
            // 
            this.gbDadosLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbDadosLogin.Controls.Add(this.btnOK);
            this.gbDadosLogin.Controls.Add(this.btnCancelar);
            this.gbDadosLogin.Controls.Add(this.mtxtSenha);
            this.gbDadosLogin.Controls.Add(this.lbSenha);
            this.gbDadosLogin.Controls.Add(this.txtLogin);
            this.gbDadosLogin.Controls.Add(this.lbLogin);
            this.gbDadosLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosLogin.Location = new System.Drawing.Point(12, 12);
            this.gbDadosLogin.Name = "gbDadosLogin";
            this.gbDadosLogin.Size = new System.Drawing.Size(457, 181);
            this.gbDadosLogin.TabIndex = 0;
            this.gbDadosLogin.TabStop = false;
            this.gbDadosLogin.Text = "Dados de Login";
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(341, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 51);
            this.btnOK.TabIndex = 3;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(226, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 51);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mtxtSenha
            // 
            this.mtxtSenha.Location = new System.Drawing.Point(110, 80);
            this.mtxtSenha.Name = "mtxtSenha";
            this.mtxtSenha.Size = new System.Drawing.Size(178, 23);
            this.mtxtSenha.TabIndex = 2;
            this.mtxtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(52, 83);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(52, 16);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(110, 51);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(298, 23);
            this.txtLogin.TabIndex = 1;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(57, 54);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(47, 16);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login:";
            // 
            // wfLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(481, 205);
            this.Controls.Add(this.gbDadosLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfLogin_FormClosing);
            this.Load += new System.EventHandler(this.wfLogin_Load);
            this.gbDadosLogin.ResumeLayout(false);
            this.gbDadosLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosLogin;
        private System.Windows.Forms.MaskedTextBox mtxtSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
    }
}