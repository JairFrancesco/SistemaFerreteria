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
    public partial class FormSistemaVendedor : Form
    {
        public FormSistemaVendedor()
        {
            InitializeComponent();
        }

        private void btningresarCliente_Click(object sender, EventArgs e)
        {
            FormInsertCliente frmcliente = new FormInsertCliente();
            frmcliente.Show();
        }

        private void btnInformacionProductos_Click(object sender, EventArgs e)
        {
            FormSelectProductos selectproductos = new FormSelectProductos();
            selectproductos.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInsertCliente Cliente = new FormInsertCliente();
            Cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistroCompra Compra = new FormRegistroCompra();
            Compra.Show();
        }

        private void btnStockProducto_Click(object sender, EventArgs e)
        {
            FormStockProductos prod = new FormStockProductos();
            prod.Show();
        }

        private void FormSistemaVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
