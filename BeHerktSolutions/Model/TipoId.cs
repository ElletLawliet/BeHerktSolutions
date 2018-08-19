using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Model
{
    class TipoId
    {

        public TipoId() { }

        public TipoId(int secuencia, string codigo, string descripcion, char estado)
        {
            this.Secuencia = secuencia;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Estado = estado;
        }

        public TipoId(string codigo, string descripcion, char estado)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Estado = estado;
        }


        public int Secuencia { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public char Estado { get; set; }

        override
        public string ToString()
        {
            return Descripcion;
        }

        public override bool Equals(object obj)
        {
            var id = obj as TipoId;
            return id != null &&
                   Secuencia == id.Secuencia &&
                   Codigo == id.Codigo &&
                   Descripcion == id.Descripcion;
        }
    }
}
