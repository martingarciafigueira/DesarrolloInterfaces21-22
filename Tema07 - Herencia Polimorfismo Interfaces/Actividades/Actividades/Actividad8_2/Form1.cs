using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo(10, 20);
            MessageBox.Show(triangulo.dibujar());
        }

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo(10, 50);
            MessageBox.Show(circulo.dibujar());
        }

        private void btnCrearRectangulo_Click(object sender, EventArgs e)
        {
            Rectangulo rectangulo = new Rectangulo(30, 50);
            MessageBox.Show(rectangulo.dibujar());
        }
    }
}
