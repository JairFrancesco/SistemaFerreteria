namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormReporteClientes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SistemaFerreteriaDataSet5 = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet5();
            this.REPORTECLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.REPORTECLIENTESTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet5TableAdapters.REPORTECLIENTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaFerreteriaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTECLIENTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteClientesDataSet";
            reportDataSource1.Value = this.REPORTECLIENTESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaFerreteria_VENTAS_ALMACEN.ReporteClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 303);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemaFerreteriaDataSet5
            // 
            this.SistemaFerreteriaDataSet5.DataSetName = "SistemaFerreteriaDataSet5";
            this.SistemaFerreteriaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORTECLIENTESBindingSource
            // 
            this.REPORTECLIENTESBindingSource.DataMember = "REPORTECLIENTES";
            this.REPORTECLIENTESBindingSource.DataSource = this.SistemaFerreteriaDataSet5;
            // 
            // REPORTECLIENTESTableAdapter
            // 
            this.REPORTECLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 303);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteClientes";
            this.Text = "Reporte de Clientes";
            this.Load += new System.EventHandler(this.FormReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaFerreteriaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTECLIENTESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORTECLIENTESBindingSource;
        private SistemaFerreteriaDataSet5 SistemaFerreteriaDataSet5;
        private SistemaFerreteriaDataSet5TableAdapters.REPORTECLIENTESTableAdapter REPORTECLIENTESTableAdapter;
    }
}