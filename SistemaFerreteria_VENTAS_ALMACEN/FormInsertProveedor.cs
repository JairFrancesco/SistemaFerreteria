using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFerreteria_VENTAS_ALMACEN
{
    public partial class FormInsertProveedor : Form
    {
        public FormInsertProveedor()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtruc.Clear();
            txtnombres.Clear();
            txttelefono.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtruc.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtnombres.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txttelefono.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtruc.Enabled = false;
            btnactualizar.Visible = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.INSERTPROVEEDOREMPRESA(txtruc.Text, txtnombres.Text, txttelefono.Text);
            fe.SaveChanges();
            cargar();
            txtruc.Enabled = true;
        }

        private void FormInsertProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorEmpresasDataSet.tproveedoresempresas' Puede moverla o quitarla según sea necesario.
            cargar();


        }
        public void cargar() {
            this.tproveedoresempresasTableAdapter.Fill(this.proveedorEmpresasDataSet.tproveedoresempresas);
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.UPDATEPROVEEDOREMPRESA(txtruc.Text, txtnombres.Text, txttelefono.Text);
            fe.SaveChanges();
            cargar();
            btnactualizar.Visible = false;
            txtruc.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.DELETEPROVEEDOREMPRESA(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            fe.SaveChanges();
            cargar();
            txtruc.Enabled = true;
        }
    }
}
