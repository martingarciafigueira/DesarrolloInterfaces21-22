using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad9
{
    public partial class Form1 : Form
    {
        BindingList<Publicacion> listaPublicaciones = new BindingList<Publicacion>();
        public Form1()
        {
            InitializeComponent();
            lstPublicaciones.DataSource = listaPublicaciones;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearLibro_Click(object sender, EventArgs e)
        {
            string titulo, autor;
            double precio;

            titulo = txtTituloLibro.Text;
            autor = txtAutor.Text;
            double.TryParse(txtPrecioLibro.Text, out precio);

            Libro nuevoLibro = new Libro(titulo, precio, autor);

            if (nuevoLibro is Libro)
            {
                if (!listaPublicaciones.Contains(nuevoLibro))
                {
                    listaPublicaciones.Add(nuevoLibro);
                }
            }
        }

        private void btnCrearDVD_Click(object sender, EventArgs e)
        {
            string titulo;
            int duracion;
            double precio;

            titulo = txtTituloDVD.Text;
            int.TryParse(txtDuracion.Text, out duracion);
            double.TryParse(txtPrecioDVD.Text, out precio);

            DVD nuevoDVD = new DVD(titulo, precio, duracion);       

            if (nuevoDVD is DVD)
            {
                if (!listaPublicaciones.Contains(nuevoDVD as Publicacion))
                {
                    listaPublicaciones.Add(nuevoDVD);
                }
            }
        }
    }
}
