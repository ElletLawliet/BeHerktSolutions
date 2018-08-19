using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Model
{
    class TipoPlan
    {

        public TipoPlan() { }

        public TipoPlan(int secuencia, string codigo, TipoDescuento tipoDescuento, string descripcion, 
            int porcentaje, char estado)
        {
            this.Secuencia = secuencia;
            this.Codigo = codigo;
            this.TipoDescuento = tipoDescuento;
            this.Descripcion = descripcion;
            this.Porcentaje = porcentaje;
            this.Estado = estado;
        }

        public TipoPlan(string codigo, TipoDescuento tipoDescuento, string descripcion, int porcentaje,
            char estado)
        {
            this.Codigo = codigo;
            this.TipoDescuento = tipoDescuento;
            this.Descripcion = descripcion;
            this.Porcentaje = porcentaje;
            this.Estado = estado;
        }

        public int Secuencia { get; set; }
        public string Codigo { get; set; }
        public TipoDescuento TipoDescuento { get; set; }
        public string Descripcion { get; set; }
        public int Porcentaje { get; set; }
        public char Estado { get; set; }

    }
}
