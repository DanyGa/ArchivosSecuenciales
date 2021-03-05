using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosSecuenciales
{
    public partial class frmAS : Form
    {
        public frmAS()
        {
            InitializeComponent();
        }

        Opciones x = new Opciones();
        private void altasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogBoxAltasProductos altas = new DialogBoxAltasProductos();
            if (altas.ShowDialog() == DialogResult.OK)
            {
                x.AltasProductos(altas.Clave, altas.Descripcion, altas.Precio);
            }
        }

        private void claveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.PorClave();
        }

        private void descripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.PorDescripcion();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.ConsultaProductos(lvProductos);
        }

        private void modificacionesDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.ModificarProductos();
            x.ConsultaProductos(lvProductos);
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.BajasProductos();
            x.ConsultaProductos(lvProductos);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
