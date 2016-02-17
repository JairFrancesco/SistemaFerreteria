namespace SistemaFerreteria_VENTAS_ALMACEN
{
    partial class FormInsertUsuario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipoUsuarioDataSet = new SistemaFerreteria_VENTAS_ALMACEN.TipoUsuarioDataSet();
            this.ttipousuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttipousuariosTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.TipoUsuarioDataSetTableAdapters.ttipousuariosTableAdapter();
            this.sistemaFerreteriaDataSet8 = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet8();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new SistemaFerreteria_VENTAS_ALMACEN.SistemaFerreteriaDataSet8TableAdapters.USUARIOSTableAdapter();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniausuarioDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreTipoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttipousuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFerreteriaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.contraseniausuarioDataGridViewImageColumn,
            this.nombreTipoUsuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSUARIOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 200);
            this.dataGridView1.TabIndex = 26;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(150, 86);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(235, 20);
            this.txtnombres.TabIndex = 23;
            this.txtnombres.UseSystemPasswordChar = true;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(151, 52);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(235, 20);
            this.txtdni.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre de Usuario";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323007_211814;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(392, 44);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(86, 49);
            this.btnactualizar.TabIndex = 32;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323122_211934;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(483, 104);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(86, 49);
            this.btneliminar.TabIndex = 31;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398322913_211650;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(391, 104);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(86, 49);
            this.btnnuevo.TabIndex = 30;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323207_211729;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(483, 44);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(86, 49);
            this.btneditar.TabIndex = 29;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources._1398323561_213109;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(391, 44);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(86, 49);
            this.btnguardar.TabIndex = 27;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ttipousuariosBindingSource;
            this.comboBox1.DisplayMember = "Nombre_TipoUsuario";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "Id_TipoUsuario";
            // 
            // tipoUsuarioDataSet
            // 
            this.tipoUsuarioDataSet.DataSetName = "TipoUsuarioDataSet";
            this.tipoUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ttipousuariosBindingSource
            // 
            this.ttipousuariosBindingSource.DataMember = "ttipousuarios";
            this.ttipousuariosBindingSource.DataSource = this.tipoUsuarioDataSet;
            // 
            // ttipousuariosTableAdapter
            // 
            this.ttipousuariosTableAdapter.ClearBeforeFill = true;
            // 
            // sistemaFerreteriaDataSet8
            // 
            this.sistemaFerreteriaDataSet8.DataSetName = "SistemaFerreteriaDataSet8";
            this.sistemaFerreteriaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.sistemaFerreteriaDataSet8;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            this.nombreusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseniausuarioDataGridViewImageColumn
            // 
            this.contraseniausuarioDataGridViewImageColumn.DataPropertyName = "contrasenia_usuario";
            this.contraseniausuarioDataGridViewImageColumn.HeaderText = "contrasenia_usuario";
            this.contraseniausuarioDataGridViewImageColumn.Name = "contraseniausuarioDataGridViewImageColumn";
            this.contraseniausuarioDataGridViewImageColumn.ReadOnly = true;
            // 
            // nombreTipoUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreTipoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_TipoUsuario";
            this.nombreTipoUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre_TipoUsuario";
            this.nombreTipoUsuarioDataGridViewTextBoxColumn.Name = "nombreTipoUsuarioDataGridViewTextBoxColumn";
            this.nombreTipoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormInsertUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaFerreteria_VENTAS_ALMACEN.Properties.Resources.fondos_verdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsertUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormInsertUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttipousuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFerreteriaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private TipoUsuarioDataSet tipoUsuarioDataSet;
        private System.Windows.Forms.BindingSource ttipousuariosBindingSource;
        private TipoUsuarioDataSetTableAdapters.ttipousuariosTableAdapter ttipousuariosTableAdapter;
        private SistemaFerreteriaDataSet8 sistemaFerreteriaDataSet8;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private SistemaFerreteriaDataSet8TableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn contraseniausuarioDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoUsuarioDataGridViewTextBoxColumn;
    }
}