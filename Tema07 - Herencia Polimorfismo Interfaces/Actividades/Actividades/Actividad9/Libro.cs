using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad9
{
    class Libro : Publicacion, IEquatable<Libro>
    {
        string autor;

        public Libro(string titulo, double precio, string autor) : base(titulo, precio)
        {
            this.Autor = autor;
        }
        public string Autor { get => autor; set => autor = value; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Libro);
        }

        public bool Equals(Libro other)
        {
            return other != null &&
                   Titulo == other.Titulo &&
                   Precio == other.Precio &&
                   autor == other.autor &&
                   Autor == other.Autor;
        }

        public override int GetHashCode()
        {
            int hashCode = -1933686825;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titulo);
            hashCode = hashCode * -1521134295 + Precio.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(autor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Autor);
            return hashCode;
        }

        public override void imprimir()
        {
            throw new NotImplementedException();
        }
    }
}