using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArchivosSecuenciales
{
    public partial class DialogBoxModificacionProductos : Form
    {
        public DialogBoxModificacionProductos()
        {
            InitializeComponent();
        }

        public string Clave
        {
            get
            {
                return (txtClaveM.Text);
            }
        }
        public string Descripcion
        {
            get
            {
                return (txtDesM.Text);
            }
        }
        public string Precio
        {
            get
            {
                return (txtPrecioM.Text);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllLines("ArchivoSecuencial.txt");
            string clave = txtClaveM.Text;
            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i] == clave)
                {
                    gbModificar.Enabled = true;
                }
            }
        }
    }
}
