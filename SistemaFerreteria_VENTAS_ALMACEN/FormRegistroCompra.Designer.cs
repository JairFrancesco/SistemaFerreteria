namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormRegistroCompra
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtipopago = new System.Windows.Forms.ComboBox();
            this.tTipopagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPagoDataSet = new SistemaFerreteria_VENTAS_ALMACEN.TipoPagoDataSet();
            this.tTipopagosTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.TipoPagoDataSetTableAdapters.tTipopagosTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbdnicliente = new System.Windows.Forms.ComboBox();
            this.sistemaFerreteriaDataSet2 = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet2();
            this.tclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tclientesTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet2TableAdapters.tclientesTableAdapter();
            this.cbdniempleado = new System.Windows.Forms.ComboBox();
            this.sistemaFerreteriaDataSet3 = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet3();
            this.templeadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templeadosTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet3TableAdapters.templeadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipopagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFerreteriaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFerreteriaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323122_211934;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(416, 228);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(86, 49);
            this.btneliminar.TabIndex = 31;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398322913_211650;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(458, 92);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(86, 49);
            this.btnnuevo.TabIndex = 30;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Enabled = false;
            this.dtpfecha.Location = new System.Drawing.Point(126, 135);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 28;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323561_213109;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(458, 28);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(86, 49);
            this.btnguardar.TabIndex = 27;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(441, 167);
            this.dataGridView1.TabIndex = 26;
            // 
            // txtfactura
            // 
            this.txtfactura.Location = new System.Drawing.Point(126, 28);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(235, 20);
            this.txtfactura.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dni del Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo de Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dni del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero de Factura";
            // 
            // cbtipopago
            // 
            this.cbtipopago.DataSource = this.tTipopagosBindingSource;
            this.cbtipopago.DisplayMember = "nombre_Tipopago";
            this.cbtipopago.FormattingEnabled = true;
            this.cbtipopago.Location = new System.Drawing.Point(99, 82);
            this.cbtipopago.Name = "cbtipopago";
            this.cbtipopago.Size = new System.Drawing.Size(121, 21);
            this.cbtipopago.TabIndex = 33;
            this.cbtipopago.ValueMember = "id_tipopago";
            // 
            // tTipopagosBindingSource
            // 
            this.tTipopagosBindingSource.DataMember = "tTipopagos";
            this.tTipopagosBindingSource.DataSource = this.tipoPagoDataSet;
            // 
            // tipoPagoDataSet
            // 
            this.tipoPagoDataSet.DataSetName = "TipoPagoDataSet";
            this.tipoPagoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTipopagosTableAdapter
            // 
            this.tTipopagosTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(232, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Productos a Adquirir";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(46, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 76);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Productos";
            // 
            // button1
            // 
            this.button1.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources.Search;
            this.button1.Location = new System.Drawing.Point(15, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbdnicliente
            // 
            this.cbdnicliente.DataSource = this.tclientesBindingSource;
            this.cbdnicliente.DisplayMember = "dni_cliente";
            this.cbdnicliente.FormattingEnabled = true;
            this.cbdnicliente.Location = new System.Drawing.Point(102, 53);
            this.cbdnicliente.Name = "cbdnicliente";
            this.cbdnicliente.Size = new System.Drawing.Size(121, 21);
            this.cbdnicliente.TabIndex = 37;
            this.cbdnicliente.ValueMember = "dni_cliente";
            // 
            // sistemaFerreteriaDataSet2
            // 
            this.sistemaFerreteriaDataSet2.DataSetName = "SistemaFerreteriaDataSet2";
            this.sistemaFerreteriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tclientesBindingSource
            // 
            this.tclientesBindingSource.DataMember = "tclientes";
            this.tclientesBindingSource.DataSource = this.sistemaFerreteriaDataSet2;
            // 
            // tclientesTableAdapter
            // 
            this.tclientesTableAdapter.ClearBeforeFill = true;
            // 
            // cbdniempleado
            // 
            this.cbdniempleado.DataSource = this.templeadosBindingSource;
            this.cbdniempleado.DisplayMember = "dni_empleado";
            this.cbdniempleado.FormattingEnabled = true;
            this.cbdniempleado.Location = new System.Drawing.Point(118, 107);
            this.cbdniempleado.Name = "cbdniempleado";
            this.cbdniempleado.Size = new System.Drawing.Size(121, 21);
            this.cbdniempleado.TabIndex = 38;
            this.cbdniempleado.ValueMember = "dni_empleado";
            // 
            // sistemaFerreteriaDataSet3
            // 
            this.sistemaFerreteriaDataSet3.DataSetName = "SistemaFerreteriaDataSet3";
            this.sistemaFerreteriaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // templeadosBindingSource
            // 
            this.templeadosBindingSource.DataMember = "templeados";
            this.templeadosBindingSource.DataSource = this.sistemaFerreteriaDataSet3;
            // 
            // templeadosTableAdapter
            // 
            this.templeadosTableAdapter.ClearBeforeFill = true;
            // 
            // FormRegistroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 471);
            this.Controls.Add(this.cbdniempleado);
            this.Controls.Add(this.cbdnicliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbtipopago);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtfactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistroCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Compra";
            this.Load += new System.EventHandler(this.FormRegistroCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipopagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFerreteriaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFerreteriaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtipopago;
        private TipoPagoDataSet tipoPagoDataSet;
        private System.Windows.Forms.BindingSource tTipopagosBindingSource;
        private TipoPagoDataSetTableAdapters.tTipopagosTableAdapter tTipopagosTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbdnicliente;
        private SistemaFerreteriaDataSet2 sistemaFerreteriaDataSet2;
        private System.Windows.Forms.BindingSource tclientesBindingSource;
        private SistemaFerreteriaDataSet2TableAdapters.tclientesTableAdapter tclientesTableAdapter;
        private System.Windows.Forms.ComboBox cbdniempleado;
        private SistemaFerreteriaDataSet3 sistemaFerreteriaDataSet3;
        private System.Windows.Forms.BindingSource templeadosBindingSource;
        private SistemaFerreteriaDataSet3TableAdapters.templeadosTableAdapter templeadosTableAdapter;
    }
}