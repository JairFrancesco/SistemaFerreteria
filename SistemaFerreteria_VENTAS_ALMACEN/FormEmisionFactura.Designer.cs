﻿namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormEmisionFactura
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
            this.FacturaDataSet = new SistemaFerreteria_VENTAS_ALMACEN.FacturaDataSet();
            this.FACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FACTURATableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.FacturaDataSetTableAdapters.FACTURATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FACTURABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaFerreteria_VENTAS_ALMACEN.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(525, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturaDataSet
            // 
            this.FacturaDataSet.DataSetName = "FacturaDataSet";
            this.FacturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FACTURABindingSource
            // 
            this.FACTURABindingSource.DataMember = "FACTURA";
            this.FACTURABindingSource.DataSource = this.FacturaDataSet;
            // 
            // FACTURATableAdapter
            // 
            this.FACTURATableAdapter.ClearBeforeFill = true;
            // 
            // FormEmisionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 412);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormEmisionFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FormEmisionFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FACTURABindingSource;
        private FacturaDataSet FacturaDataSet;
        private FacturaDataSetTableAdapters.FACTURATableAdapter FACTURATableAdapter;
    }
}