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
    public partial class FormRegistroSuministro : Form
    {
        public FormRegistroSuministro()
        {
            InitializeComponent();
        }

        private void FormRegistroSuministro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productsDataSet.tproductos' Puede moverla o quitarla según sea necesario.
            this.tproductosTableAdapter.Fill(this.productsDataSet.tproductos);
            // TODO: esta línea de código carga datos en la tabla 'empresasDataSet.tsuministrosempresas' Puede moverla o quitarla según sea necesario.
            this.tsuministrosempresasTableAdapter.Fill(this.empresasDataSet.tsuministrosempresas);

        }
    }
}
