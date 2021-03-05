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
    public partial class DialogBoxDescripcion : Form
    {
        public DialogBoxDescripcion()
        {
            InitializeComponent();
        }

        //Descripcion del Producto a buscar
        public string Descripcion
        {
            get
            {
                return (txtDesD.Text);
            }
        }
    }
}
