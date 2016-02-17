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
    public partial class FormSistemaAlmacen : Form
    {
        public FormSistemaAlmacen()
        {
            InitializeComponent();
        }

        private void FormSistemaAlmacen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInsertProducto producto = new FormInsertProducto();
            producto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormInsertProveedor proveedor = new FormInsertProveedor();
            proveedor.Show();
        }

        private void btnStockProducto_Click(object sender, EventArgs e)
        {
            FormStockProductos prod = new FormStockProductos();
            prod.Show();
        }

        private void btnrelacionsuministro_Click(object sender, EventArgs e)
        {
            FormRegistroSuministro sum = new FormRegistroSuministro();
            sum.Show();
        }

    }
}
