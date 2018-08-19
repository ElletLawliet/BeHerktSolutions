using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Model
{
    class TipoDescuento
    {

        public TipoDescuento() { }

        public TipoDescuento(int secuencia, string codigo, TipoId tipoId, string descripcion,
            int multiplo, char estado)
        {
            this.Secuencia = secuencia;
            this.Codigo = codigo;
            this.TipoId = tipoId;
            this.Descripcion = descripcion;
            this.Multiplo = multiplo;
            this.Estado = estado;
        }

        public TipoDescuento(string codigo, TipoId tipoId, string descripcion, int multiplo,
            char estado)
        {
            this.Codigo = codigo;
            this.TipoId = tipoId;
            this.Descripcion = descripcion;
            this.Multiplo = multiplo;
            this.Estado = estado;
        }

        public int Secuencia { get; set; }
        public string Codigo { get; set; }
        public TipoId TipoId { get; set; }
        public string Descripcion { get; set; }
        public int Multiplo { get; set; }
        public char Estado { get; set; }
    }
}
