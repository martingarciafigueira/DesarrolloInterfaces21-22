using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8_2
{
    public class Rectangulo : FormaGeometrica
    {
        public Rectangulo(float alto, float ancho) : base(alto, ancho)
        {
        }

        public override string dibujar()
        {
            return "Se dibuja como un rectángulo";
        }

        public override float calcularArea()
        {
            return this.Alto * this.ancho;
        }
    }
}
