using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SistemaFerreteria_VENTAS_ALMACEN
{
    public partial class FormEmisionFactura : Form
    {
        public int numerofactura;
        public FormEmisionFactura()
        {
            InitializeComponent();
        }

        private void FormEmisionFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'FacturaDataSet.FACTURA' Puede moverla o quitarla según sea necesario.
            this.FACTURATableAdapter.Fill(this.FacturaDataSet.FACTURA, numerofactura);
            DataSet midataset = new DataSet();
            Datos.ConexionBaseDatos cn = new Datos.ConexionBaseDatos();
            SqlCommand sqlcom = new SqlCommand("FACTURA", cn.Conn);
            cn.ObtenerConexion();
            sqlcom.Parameters.AddWithValue("@NUMERO_FACTURA", numerofactura);
            sqlcom.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            adapter.Fill(midataset);

            this.reportViewer1.RefreshReport();

        }
    }
}
