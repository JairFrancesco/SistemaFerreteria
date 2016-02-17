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
    public partial class MDISistemaAdmin : Form
    {
        private int childFormNumber = 0;

        public MDISistemaAdmin()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertTrabajador childForm = new FormInsertTrabajador();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void sistemaDeVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSistemaVendedor childForm = new FormSistemaVendedor();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void sistemaDeAlmaceneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSistemaAlmacen childForm = new FormSistemaAlmacen();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteVentas childForm = new FormReporteVentas();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void reporteStockDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStockProductos childForm = new FormStockProductos();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertUsuario childForm = new FormInsertUsuario();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteClientes Repr = new FormReporteClientes();
            Repr.Show();
        }
    }
}
