using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8_2
{
    class Triangulo : FormaGeometrica
    {
        public Triangulo(float alto, float ancho) : base(alto, ancho)
        {
        }

        public override string dibujar()
        {
            return "Se dibuja como un triángulo";
        }
        public override float calcularArea()
        {
            return (this.Alto * this.ancho) / 2;
        }
    }
}
