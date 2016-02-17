namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormInsertCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dniclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaFerreteriaDataSet = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet();
            this.tclientesTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSetTableAdapters.tclientesTableAdapter();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFerreteriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(108, 39);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(235, 20);
            this.txtdni.TabIndex = 5;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(117, 65);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(235, 20);
            this.txtnombres.TabIndex = 6;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(117, 91);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(235, 20);
            this.txtapellidos.TabIndex = 7;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(117, 143);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(235, 20);
            this.txttelefono.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.apellidosclienteDataGridViewTextBoxColumn,
            this.nacimientoclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tclientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 200);
            this.dataGridView1.TabIndex = 10;
            // 
            // dniclienteDataGridViewTextBoxColumn
            // 
            this.dniclienteDataGridViewTextBoxColumn.DataPropertyName = "dni_cliente";
            this.dniclienteDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniclienteDataGridViewTextBoxColumn.Name = "dniclienteDataGridViewTextBoxColumn";
            this.dniclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosclienteDataGridViewTextBoxColumn
            // 
            this.apellidosclienteDataGridViewTextBoxColumn.DataPropertyName = "apellidos_cliente";
            this.apellidosclienteDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosclienteDataGridViewTextBoxColumn.Name = "apellidosclienteDataGridViewTextBoxColumn";
            this.apellidosclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacimientoclienteDataGridViewTextBoxColumn
            // 
            this.nacimientoclienteDataGridViewTextBoxColumn.DataPropertyName = "nacimiento_cliente";
            this.nacimientoclienteDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            this.nacimientoclienteDataGridViewTextBoxColumn.Name = "nacimientoclienteDataGridViewTextBoxColumn";
            this.nacimientoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            this.telefonoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tclientesBindingSource
            // 
            this.tclientesBindingSource.DataMember = "tclientes";
            this.tclientesBindingSource.DataSource = this.sistemaFerreteriaDataSet;
            // 
            // sistemaFerreteriaDataSet
            // 
            this.sistemaFerreteriaDataSet.DataSetName = "SistemaFerreteriaDataSet";
            this.sistemaFerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tclientesTableAdapter
            // 
            this.tclientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323561_213109;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(406, 31);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(86, 49);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Location = new System.Drawing.Point(176, 117);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpnacimiento.TabIndex = 12;
            // 
            // btneditar
            // 
            this.btneditar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323207_211729;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(498, 31);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(86, 49);
            this.btneditar.TabIndex = 13;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398322913_211650;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(406, 91);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(86, 49);
            this.btnnuevo.TabIndex = 14;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323122_211934;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(498, 91);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(86, 49);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323007_211814;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(406, 31);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(86, 49);
            this.btnactualizar.TabIndex = 16;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Visible = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // FormInsertCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources.fondos_verdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 393);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dtpnacimiento);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsertCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Cliente";
            this.Load += new System.EventHandler(this.FormInsertCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFerreteriaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SistemaFerreteriaDataSet sistemaFerreteriaDataSet;
        private System.Windows.Forms.BindingSource tclientesBindingSource;
        private SistemaFerreteriaDataSetTableAdapters.tclientesTableAdapter tclientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
    }
}