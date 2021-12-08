using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad9
{
    class DVD : Publicacion
    {
        int duracion;

        public DVD(string titulo, double precio, int duracion) : base(titulo, precio)
        {
            this.Duracion = duracion;
        }

        public int Duracion { get => duracion; set => duracion = value; }

        public override bool Equals(object obj)
        {
            return obj is DVD dVD &&
                   Titulo == dVD.Titulo;
        }

        public override int GetHashCode()
        {
            return 2138279000 + EqualityComparer<string>.Default.GetHashCode(Titulo);
        }

        public override void imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
