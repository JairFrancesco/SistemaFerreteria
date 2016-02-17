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
    public partial class FormRegistroCompra : Form
    {
        DataTable dt;
        public FormRegistroCompra()
        {
            InitializeComponent();
        }

        private void FormRegistroCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaFerreteriaDataSet3.templeados' Puede moverla o quitarla según sea necesario.
            this.templeadosTableAdapter.Fill(this.sistemaFerreteriaDataSet3.templeados);
            // TODO: esta línea de código carga datos en la tabla 'sistemaFerreteriaDataSet2.tclientes' Puede moverla o quitarla según sea necesario.
            this.tclientesTableAdapter.Fill(this.sistemaFerreteriaDataSet2.tclientes);
            // TODO: esta línea de código carga datos en la tabla 'tipoPagoDataSet.tTipopagos' Puede moverla o quitarla según sea necesario.
            this.tTipopagosTableAdapter.Fill(this.tipoPagoDataSet.tTipopagos);
            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Cantidad");
        }
        public DataGridViewRow dgr;
        private void button1_Click(object sender, EventArgs e)
        {
            FormProductosCompra productos = new FormProductosCompra();
            productos.ShowDialog();
            DataRow fila = dt.NewRow();
            dt.Rows.Add(fila);
            fila["Codigo"] = productos.codigoproducto;
            fila["Descripcion"] = productos.DescripcionProducto;
            fila["Cantidad"] = productos.cantidadcompra;
            dataGridView1.DataSource = dt;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtfactura.Clear();
            dt.Rows.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try{
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.GUARDARCOMPRAS(int.Parse(txtfactura.Text),int.Parse(cbdnicliente.SelectedValue.ToString()), int.Parse(cbtipopago.SelectedValue.ToString()), int.Parse(cbdniempleado.SelectedValue.ToString()), dtpfecha.Value);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fe.GUARDARDETALLES(int.Parse(txtfactura.Text), int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()), int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }
        }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                }
            FormEmisionFactura factura = new FormEmisionFactura();
            factura.numerofactura = int.Parse(txtfactura.Text);
            factura.Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dt.Rows[int.Parse(dataGridView1.CurrentRow.Index.ToString())].Delete();
            dataGridView1.DataSource = dt;
        }

    }
}
