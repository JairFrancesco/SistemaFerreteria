namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormReporteVentas
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
            this.SistemaFerreteriaDataSet7 = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet7();
            this.REPORTEVENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.REPORTEVENTASTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet7TableAdapters.REPORTEVENTASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaFerreteriaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTEVENTASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteVentasDataSet";
            reportDataSource1.Value = this.REPORTEVENTASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaFerreteria_VENTAS_ALMACEN.ReporteVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(604, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemaFerreteriaDataSet7
            // 
            this.SistemaFerreteriaDataSet7.DataSetName = "SistemaFerreteriaDataSet7";
            this.SistemaFerreteriaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORTEVENTASBindingSource
            // 
            this.REPORTEVENTASBindingSource.DataMember = "REPORTEVENTAS";
            this.REPORTEVENTASBindingSource.DataSource = this.SistemaFerreteriaDataSet7;
            // 
            // REPORTEVENTASTableAdapter
            // 
            this.REPORTEVENTASTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 427);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.FormReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaFerreteriaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTEVENTASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORTEVENTASBindingSource;
        private SistemaFerreteriaDataSet7 SistemaFerreteriaDataSet7;
        private SistemaFerreteriaDataSet7TableAdapters.REPORTEVENTASTableAdapter REPORTEVENTASTableAdapter;
    }
}