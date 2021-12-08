using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8_2
{
    public abstract class FormaGeometrica
    {
        protected float alto;
        protected float ancho;

        public FormaGeometrica(float alto, float ancho)
        {
            this.Alto = alto;
            this.Ancho = ancho;
        }

        public float Alto { get => alto; set => alto = value; }
        public float Ancho { get => ancho; set => ancho = value; }

        public virtual string dibujar()
        {
            return "Se dibuja como una forma geométrica";
        }

        public abstract float calcularArea();

    }
}
