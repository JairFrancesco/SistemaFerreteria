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
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas()
        {
            InitializeComponent();
        }

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaFerreteriaDataSet7.REPORTEVENTAS' Puede moverla o quitarla según sea necesario.
            this.REPORTEVENTASTableAdapter.Fill(this.SistemaFerreteriaDataSet7.REPORTEVENTAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
