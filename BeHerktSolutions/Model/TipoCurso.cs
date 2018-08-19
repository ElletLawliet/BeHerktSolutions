using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Model
{
    class TipoCurso
    {

        public TipoCurso() { }

        public TipoCurso(int secuencia, string codigo, string descripcion,
            double precio, char estado)
        {
            this.Secuencia = secuencia;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Estado = estado;
        }

        public TipoCurso(string codigo, string descripcion, double precio, 
            char estado)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Estado = estado;
        }

        public int Secuencia { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public char Estado { get; set; }


    }
}
