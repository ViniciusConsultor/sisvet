namespace StockPC
{
    partial class wfRelCategoria
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
            this.tbcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet = new StockPC.estoqueDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbcategoriaTableAdapter = new StockPC.estoqueDataSetTableAdapters.tbcategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbcategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcategoriaBindingSource
            // 
            this.tbcategoriaBindingSource.DataMember = "tbcategoria";
            this.tbcategoriaBindingSource.DataSource = this.estoqueDataSet;
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "estoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbcategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockPC.rptCategoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(994, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbcategoriaTableAdapter
            // 
            this.tbcategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // wfRelCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 412);
            this.Controls.Add(this.reportViewer1);
            this.Name = "wfRelCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Categorias";
            this.Load += new System.EventHandler(this.wfRepCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbcategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbcategoriaBindingSource;
        private estoqueDataSet estoqueDataSet;
        private estoqueDataSetTableAdapters.tbcategoriaTableAdapter tbcategoriaTableAdapter;
    }
}