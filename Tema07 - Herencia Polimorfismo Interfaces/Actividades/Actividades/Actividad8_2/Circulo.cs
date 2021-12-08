using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8_2
{
    class Circulo : FormaGeometrica
    {
        public Circulo(float alto, float ancho) : base(alto, ancho)
        {
        }

        public override string dibujar()
        {
            return "Se dibuja como un círculo";
        }

        public override float calcularArea()
        {
            return (float) (Math.PI * Math.Pow(alto, 2));
        }
    }
}
