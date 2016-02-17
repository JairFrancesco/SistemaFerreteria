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
    public partial class FormInsertUsuario : Form
    {
        public FormInsertUsuario()
        {
            InitializeComponent();
        }

        private void FormInsertUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaFerreteriaDataSet8.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.sistemaFerreteriaDataSet8.USUARIOS);
            // TODO: esta línea de código carga datos en la tabla 'tipoUsuarioDataSet.ttipousuarios' Puede moverla o quitarla según sea necesario.
            this.ttipousuariosTableAdapter.Fill(this.tipoUsuarioDataSet.ttipousuarios);

        }
    }
}
