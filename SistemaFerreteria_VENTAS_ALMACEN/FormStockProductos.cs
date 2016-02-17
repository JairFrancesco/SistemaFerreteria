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
    public partial class FormStockProductos : Form
    {
        public FormStockProductos()
        {
            InitializeComponent();
        }

        private void FormStockProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaFerreteriaDataSet6.tproductos' Puede moverla o quitarla según sea necesario.
            this.tproductosTableAdapter.Fill(this.SistemaFerreteriaDataSet6.tproductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
