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
    public partial class FormProductosCompra : Form
    {
        public int codigoproducto;
        public int cantidadcompra;
        public string DescripcionProducto;
        public FormProductosCompra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cantidadcompra = int.Parse(txtcantidad.Text);
            DescripcionProducto = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            codigoproducto = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.Close();
        }

        private void FormProductosCompra_Load(object sender, EventArgs e)
        {
            DataSet midataset = new DataSet();
            Datos.ConexionBaseDatos cn = new Datos.ConexionBaseDatos();
            SqlCommand sqlcom = new SqlCommand("SELECTPRODUCTOS", cn.Conn);
            cn.ObtenerConexion();
            sqlcom.Parameters.AddWithValue("@descripcion", "");
            sqlcom.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            adapter.Fill(midataset);
            dataGridView1.DataSource = midataset.Tables[0];
        }
    }
}
