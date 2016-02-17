namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormStockProductos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SistemaFerreteriaDataSet6 = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet6();
            this.tproductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tproductosTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet6TableAdapters.tproductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaFerreteriaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tproductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ReporteProductosDataSet";
            reportDataSource2.Value = this.tproductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaFerreteria_VENTAS_ALMACEN.ReporteProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(714, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemaFerreteriaDataSet6
            // 
            this.SistemaFerreteriaDataSet6.DataSetName = "SistemaFerreteriaDataSet6";
            this.SistemaFerreteriaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tproductosBindingSource
            // 
            this.tproductosBindingSource.DataMember = "tproductos";
            this.tproductosBindingSource.DataSource = this.SistemaFerreteriaDataSet6;
            // 
            // tproductosTableAdapter
            // 
            this.tproductosTableAdapter.ClearBeforeFill = true;
            // 
            // FormStockProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 400);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormStockProductos";
            this.Text = "Reporte de Stock de Productos";
            this.Load += new System.EventHandler(this.FormStockProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaFerreteriaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tproductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tproductosBindingSource;
        private SistemaFerreteriaDataSet6 SistemaFerreteriaDataSet6;
        private SistemaFerreteriaDataSet6TableAdapters.tproductosTableAdapter tproductosTableAdapter;
    }
}