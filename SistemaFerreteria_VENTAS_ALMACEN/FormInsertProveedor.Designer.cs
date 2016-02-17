namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormInsertProveedor
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
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorEmpresasDataSet = new SistemaFerreteria_VENTAS_ALMACEN.ProveedorEmpresasDataSet();
            this.tproveedoresempresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tproveedoresempresasTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.ProveedorEmpresasDataSetTableAdapters.tproveedoresempresasTableAdapter();
            this.rUCproveedorempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproveedorempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoproveedorempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorEmpresasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tproveedoresempresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323007_211814;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(382, 35);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(86, 49);
            this.btnactualizar.TabIndex = 32;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Visible = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323122_211934;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(474, 95);
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
            this.btnnuevo.Location = new System.Drawing.Point(382, 95);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(86, 49);
            this.btnnuevo.TabIndex = 30;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323207_211729;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(474, 35);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(86, 49);
            this.btneditar.TabIndex = 29;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323561_213109;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(382, 35);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rUCproveedorempresaDataGridViewTextBoxColumn,
            this.nombreproveedorempresaDataGridViewTextBoxColumn,
            this.telefonoproveedorempresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tproveedoresempresasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 200);
            this.dataGridView1.TabIndex = 26;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(146, 108);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(166, 20);
            this.txttelefono.TabIndex = 24;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(141, 81);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(219, 20);
            this.txtnombres.TabIndex = 23;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(125, 56);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(235, 20);
            this.txtruc.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefono de la empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre de la empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "RUC de la Empresa";
            // 
            // proveedorEmpresasDataSet
            // 
            this.proveedorEmpresasDataSet.DataSetName = "ProveedorEmpresasDataSet";
            this.proveedorEmpresasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tproveedoresempresasBindingSource
            // 
            this.tproveedoresempresasBindingSource.DataMember = "tproveedoresempresas";
            this.tproveedoresempresasBindingSource.DataSource = this.proveedorEmpresasDataSet;
            // 
            // tproveedoresempresasTableAdapter
            // 
            this.tproveedoresempresasTableAdapter.ClearBeforeFill = true;
            // 
            // rUCproveedorempresaDataGridViewTextBoxColumn
            // 
            this.rUCproveedorempresaDataGridViewTextBoxColumn.DataPropertyName = "RUC_proveedorempresa";
            this.rUCproveedorempresaDataGridViewTextBoxColumn.HeaderText = "RUC";
            this.rUCproveedorempresaDataGridViewTextBoxColumn.Name = "rUCproveedorempresaDataGridViewTextBoxColumn";
            this.rUCproveedorempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreproveedorempresaDataGridViewTextBoxColumn
            // 
            this.nombreproveedorempresaDataGridViewTextBoxColumn.DataPropertyName = "Nombre_proveedorempresa";
            this.nombreproveedorempresaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproveedorempresaDataGridViewTextBoxColumn.Name = "nombreproveedorempresaDataGridViewTextBoxColumn";
            this.nombreproveedorempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoproveedorempresaDataGridViewTextBoxColumn
            // 
            this.telefonoproveedorempresaDataGridViewTextBoxColumn.DataPropertyName = "telefono_proveedorempresa";
            this.telefonoproveedorempresaDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoproveedorempresaDataGridViewTextBoxColumn.Name = "telefonoproveedorempresaDataGridViewTextBoxColumn";
            this.telefonoproveedorempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormInsertProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources.fondos_verdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 393);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsertProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormInsertProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorEmpresasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tproveedoresempresasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ProveedorEmpresasDataSet proveedorEmpresasDataSet;
        private System.Windows.Forms.BindingSource tproveedoresempresasBindingSource;
        private ProveedorEmpresasDataSetTableAdapters.tproveedoresempresasTableAdapter tproveedoresempresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUCproveedorempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoproveedorempresaDataGridViewTextBoxColumn;
    }
}