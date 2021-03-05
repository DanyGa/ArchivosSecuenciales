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
    public partial class DialogBoxBajasProductos : Form
    {
        public DialogBoxBajasProductos()
        {
            InitializeComponent();
        }

        //Clave del producto que se va a eliminar
        public string Clave
        {
            get
            {
                return (txtClaveB.Text);
            }
        }
    }
}
