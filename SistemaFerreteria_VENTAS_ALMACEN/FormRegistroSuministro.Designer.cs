namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormRegistroSuministro
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empresasDataSet = new SistemaFerreteria_VENTAS_ALMACEN.EmpresasDataSet();
            this.tsuministrosempresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsuministrosempresasTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.EmpresasDataSetTableAdapters.tsuministrosempresasTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.productsDataSet = new SistemaFerreteria_VENTAS_ALMACEN.ProductsDataSet();
            this.tproductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tproductosTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.ProductsDataSetTableAdapters.tproductosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsuministrosempresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tproductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suministrador";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tsuministrosempresasBindingSource;
            this.comboBox1.DisplayMember = "RUC_proveedorempresa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "RUC_proveedorempresa";
            // 
            // empresasDataSet
            // 
            this.empresasDataSet.DataSetName = "EmpresasDataSet";
            this.empresasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsuministrosempresasBindingSource
            // 
            this.tsuministrosempresasBindingSource.DataMember = "tsuministrosempresas";
            this.tsuministrosempresasBindingSource.DataSource = this.empresasDataSet;
            // 
            // tsuministrosempresasTableAdapter
            // 
            this.tsuministrosempresasTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto Suministrado";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tproductosBindingSource;
            this.comboBox2.DisplayMember = "descripcion_producto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(155, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(221, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "codigo_producto";
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tproductosBindingSource
            // 
            this.tproductosBindingSource.DataMember = "tproductos";
            this.tproductosBindingSource.DataSource = this.productsDataSet;
            // 
            // tproductosTableAdapter
            // 
            this.tproductosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormRegistroSuministro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources.fondos_verdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistroSuministro";
            this.Text = "Registro de Suministros";
            this.Load += new System.EventHandler(this.FormRegistroSuministro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsuministrosempresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tproductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private EmpresasDataSet empresasDataSet;
        private System.Windows.Forms.BindingSource tsuministrosempresasBindingSource;
        private EmpresasDataSetTableAdapters.tsuministrosempresasTableAdapter tsuministrosempresasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource tproductosBindingSource;
        private ProductsDataSetTableAdapters.tproductosTableAdapter tproductosTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}