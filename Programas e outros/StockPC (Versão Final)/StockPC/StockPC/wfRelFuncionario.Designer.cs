namespace StockPC
{
    partial class wfRelFuncionario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbfuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet1 = new StockPC.estoqueDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbfuncionarioTableAdapter = new StockPC.estoqueDataSet1TableAdapters.tbfuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbfuncionarioBindingSource
            // 
            this.tbfuncionarioBindingSource.DataMember = "tbfuncionario";
            this.tbfuncionarioBindingSource.DataSource = this.estoqueDataSet1;
            // 
            // estoqueDataSet1
            // 
            this.estoqueDataSet1.DataSetName = "estoqueDataSet1";
            this.estoqueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbfuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockPC.rptFuncionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1071, 457);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbfuncionarioTableAdapter
            // 
            this.tbfuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // wfRelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 457);
            this.Controls.Add(this.reportViewer1);
            this.Name = "wfRelFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Funcionários";
            this.Load += new System.EventHandler(this.wfRelFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbfuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbfuncionarioBindingSource;
        private estoqueDataSet1 estoqueDataSet1;
        private estoqueDataSet1TableAdapters.tbfuncionarioTableAdapter tbfuncionarioTableAdapter;
    }
}