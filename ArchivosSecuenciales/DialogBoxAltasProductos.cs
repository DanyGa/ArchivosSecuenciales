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
    public partial class DialogBoxAltasProductos : Form
    {
        public DialogBoxAltasProductos()
        {
            InitializeComponent();
        }

        //Datos que va a agregar
        public string Clave
        {
            get
            {
                return (txtClaveA.Text);
            }
        }
        public string Descripcion
        {
            get
            {
                return (txtDesA.Text);
            }
        }
        public string Precio
        {
            get
            {
                return (txtPrecioA.Text);
            }
        }
    }
}
