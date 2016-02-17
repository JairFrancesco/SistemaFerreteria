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
    public partial class FormReporteClientes : Form
    {
        public FormReporteClientes()
        {
            InitializeComponent();
        }

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaFerreteriaDataSet5.REPORTECLIENTES' Puede moverla o quitarla según sea necesario.
            this.REPORTECLIENTESTableAdapter.Fill(this.SistemaFerreteriaDataSet5.REPORTECLIENTES);

            this.reportViewer1.RefreshReport();
        }
    }
}
