using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ArchivosSecuenciales
{
    class Opciones
    {
        public void AltasProductos(string clave, string descripcion, string precio)
        {
            StreamWriter sw = new StreamWriter("ArchivoSecuencial.txt", true, Encoding.ASCII);
            sw.WriteLine(clave);
            sw.WriteLine(descripcion);
            sw.WriteLine(precio);
            MessageBox.Show("Datos almacenados en el archivo", "Altas de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Close();
        }

        public void ConsultaProductos(ListView ventana)
        {
            ventana.Items.Clear();
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            string clave = sr.ReadLine();
            string descripcion = sr.ReadLine();
            string precio = sr.ReadLine();
            while (clave != null)
            {
                ListViewItem lista = new ListViewItem(clave);
                lista.SubItems.Add(descripcion);
                lista.SubItems.Add(precio);
                ventana.Items.Add(lista);
                clave = sr.ReadLine();
                descripcion = sr.ReadLine();
                precio = sr.ReadLine();
            }
            sr.Close();
        }

        public void PorClave()
        {
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            DialogBoxClave num = new DialogBoxClave();
            bool bandera = true;
            if (num.ShowDialog() == DialogResult.OK)
            {
                string clave = sr.ReadLine();
                while (clave != null)
                {
                    if (clave == num.Clave)
                    {
                        bandera = false;
                    }

                    clave = sr.ReadLine();

                }
                sr.Close();
                if (bandera == true)
                {
                    MessageBox.Show("La clave del producto no existe!!!", "Bajas de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("El Producto se encontro en el archivo", "Bajas de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void PorDescripcion()
        {
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            DialogBoxDescripcion des = new DialogBoxDescripcion();
            bool bandera = true;
            if (des.ShowDialog() == DialogResult.OK)
            {
                string descripcion = sr.ReadLine();
                while (descripcion != null)
                {
                    if (descripcion == des.Descripcion)
                    {
                        bandera = false;
                    }

                    descripcion = sr.ReadLine();

                }
                sr.Close();
                if (bandera == true)
                {
                    MessageBox.Show("La clave del producto no existe!!!", "Bajas de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("El Producto se encontro en el archivo", "Bajas de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void ModificarProductos()
        {
            DialogBoxModificacionProductos mod = new DialogBoxModificacionProductos();
            if (mod.ShowDialog() == DialogResult.OK)
            {
                string[] lineas = File.ReadAllLines("ArchivoSecuencial.txt");
                string clave = mod.Clave;
                string descripcion = mod.Descripcion;
                string precio = mod.Precio;
                for (int i = 0; i < lineas.Length; i++)
                {
                    if (lineas[i] == clave)
                    {
                        lineas[i + 1] = descripcion;
                        lineas[i + 2] = precio;
                        break;
                    }
                }
                File.WriteAllLines("ArchivoSecuencial.txt", lineas);
            }
                
        }

        public void BajasProductos()
        {
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            StreamWriter sw = new StreamWriter("Auxiliar.txt", false, Encoding.ASCII);
            DialogBoxBajasProductos bajas = new DialogBoxBajasProductos();
            bool bandera = true;
            if (bajas.ShowDialog() == DialogResult.OK)
            {
                string clave = sr.ReadLine();
                string descripcion = sr.ReadLine();
                string precio = sr.ReadLine();
                while (clave != null)
                {
                    if (clave == bajas.Clave)
                    {
                        bandera = false;
                    }
                    else
                    {
                        sw.WriteLine(clave);
                        sw.WriteLine(descripcion);
                        sw.WriteLine(precio);
                    }
                    clave = sr.ReadLine();
                    descripcion = sr.ReadLine();
                    precio = sr.ReadLine();

                }
                sw.Close();
                sr.Close();
                StreamReader sr1 = new StreamReader("Auxiliar.txt");
                StreamWriter sw1 = new StreamWriter("ArchivoSecuencial.txt", false, Encoding.ASCII);
                clave = sr1.ReadLine();
                descripcion = sr1.ReadLine();
                precio = sr1.ReadLine();
                while (clave != null)
                {
                    sw1.WriteLine(clave);
                    sw1.WriteLine(descripcion);
                    sw1.WriteLine(precio);
                    clave = sr1.ReadLine();
                    descripcion = sr1.ReadLine();
                    precio = sr1.ReadLine();
                }
                sw1.Close();
                sr1.Close();
                if (bandera == true)
                {
                    MessageBox.Show("La clave del producto no existe!!!", "Bajas de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("El Producto se elimino del archivo", "Bajas de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
