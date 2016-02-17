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
    public partial class FormSelectProductos : Form
    {
        public FormSelectProductos()
        {
            InitializeComponent();
        }

        private void FormSelectProductos_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet midataset = new DataSet();
            Datos.ConexionBaseDatos cn = new Datos.ConexionBaseDatos();
            SqlCommand sqlcom = new SqlCommand("SELECTPRODUCTOS", cn.Conn);
            cn.ObtenerConexion();
            sqlcom.Parameters.AddWithValue("@descripcion", txtnombrebusqueda.Text);
            sqlcom.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            adapter.Fill(midataset);
            dataGridView1.DataSource = midataset.Tables[0];
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
    }

