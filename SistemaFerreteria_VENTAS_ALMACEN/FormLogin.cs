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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Datos.Usuario user = new Datos.Usuario();
            int tipousuario = user.VerificarUsuario(txtusuario.Text, txtclave.Text);
            if (tipousuario != 0)
            {
                if (tipousuario == 1)
                {
                    MDISistemaAdmin sisadmin = new MDISistemaAdmin();
                    sisadmin.Show();
                    this.Hide();
                }
                else
                    if (tipousuario == 2)
                    {
                        FormSistemaVendedor sisvendedor = new FormSistemaVendedor();
                        sisvendedor.Show();
                    }
                    else
                    {
                        FormSistemaAlmacen sisalmacen = new FormSistemaAlmacen();
                        sisalmacen.Show();
                    }
            }
            else
                MessageBox.Show("Usuario o Contraseña Incorrectos, Vuelva a Ingresarlos", "Error al Acceder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusuario.Clear();
                txtclave.Clear();
        }
    }
}
