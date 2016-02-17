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
    public partial class FormInsertProducto : Form
    {
        public FormInsertProducto()
        {
            InitializeComponent();
        }

        private void FormInsertProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaFerreteriaDataSet1.tproductos' Puede moverla o quitarla según sea necesario.
            cargar();
        }
        private void cargar()
        {
            DataSet midataset = new DataSet();
            Datos.ConexionBaseDatos cn = new Datos.ConexionBaseDatos();
            FerreteriaEntities fe = new FerreteriaEntities();
            SqlCommand sqlcom = new SqlCommand("SELECTPRODUCTOS", cn.Conn);
            cn.ObtenerConexion();
            sqlcom.Parameters.AddWithValue("@descripcion", "");
            sqlcom.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            adapter.Fill(midataset);
            dataGridView1.DataSource = midataset.Tables[0];
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            txtcodigo.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.DELETEPRODUCTO(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            fe.SaveChanges();
            cargar();
            txtcodigo.Enabled = true;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtdescripcion.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtprecio.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtcantidad.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtcodigo.Enabled = false;
            btnactualizar.Visible = true;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.UPDATEPRODUCTO(int.Parse(txtcodigo.Text), txtdescripcion.Text, float.Parse(txtprecio.Text), int.Parse(txtcantidad.Text));
            fe.SaveChanges();
            cargar();
            btnactualizar.Visible = false;
            txtcodigo.Enabled = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            FerreteriaEntities fe = new FerreteriaEntities();
            fe.INSERTPRODUCTO(int.Parse(txtcodigo.Text), txtdescripcion.Text, float.Parse(txtprecio.Text), int.Parse(txtcantidad.Text));
            fe.SaveChanges();
            cargar();
            txtcodigo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet midataset = new DataSet();
            Datos.ConexionBaseDatos cn = new Datos.ConexionBaseDatos();
            FerreteriaEntities fe = new FerreteriaEntities();
            SqlCommand sqlcom = new SqlCommand("SELECTPRODUCTOS", cn.Conn);
            cn.ObtenerConexion();
            sqlcom.Parameters.AddWithValue("@descripcion", txtnombrebusqueda.Text);
            sqlcom.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            adapter.Fill(midataset);
            dataGridView1.DataSource = midataset.Tables[0];
            }
        }
       }
