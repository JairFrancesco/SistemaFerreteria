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
    public partial class FormInsertCliente : Form
    {
        public FormInsertCliente()
        {
            InitializeComponent();
        }

        private void FormInsertCliente_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            this.tclientesTableAdapter.Fill(this.sistemaFerreteriaDataSet.tclientes);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtdni.Clear();
            txtnombres.Clear();
            txtapellidos.Clear();
            txttelefono.Clear();
            dtpnacimiento.Value = DateTime.Today;
            txtdni.Enabled = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.INSERTCLIENTE(int.Parse(txtdni.Text), txtnombres.Text, txtapellidos.Text, dtpnacimiento.Value, int.Parse(txttelefono.Text));
            fe.SaveChanges();
            cargar();
            txtdni.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.DELETECLIENTE(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            fe.SaveChanges();
            cargar();
            txtdni.Enabled = true;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtdni.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtnombres.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtapellidos.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dtpnacimiento.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            txttelefono.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtdni.Enabled = false;
            btnactualizar.Visible = true;

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.UPDATECLIENTE(int.Parse(txtdni.Text), txtnombres.Text, txtapellidos.Text, dtpnacimiento.Value, int.Parse(txttelefono.Text));
            fe.SaveChanges();
            cargar();
            btnactualizar.Visible = false;
            txtdni.Enabled = true;
        }
    }
}
