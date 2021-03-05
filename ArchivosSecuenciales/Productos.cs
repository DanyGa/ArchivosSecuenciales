using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosSecuenciales
{
    class Productos
    {
        //Declaracion de Propiedades
        private int clave;
        private string descripcion;
        private double precio;

        //Declaracion de Metodos get and set
        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        //Declaracion del Constructor
        public Productos()
        {
            this.clave = 0;
            this.descripcion = "";
            this.precio = 0;
        }
    }
}
