using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Model
{
    class Curso
    {

        public Curso() { }

        public Curso(int codigo, TipoCurso tipoCurso, DateTime fechaCreacion, DateTime fechaModificacion, 
            DateTime fechaInicio, DateTime fechaFin, int duracion, int cupos, 
            char estado)
        {
            this.Codigo = codigo;
            this.TipoCurso = tipoCurso;
            this.FechaCreacion = fechaCreacion;
            this.FechaModificacion = fechaModificacion;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Duracion = duracion;
            this.Cupos = cupos;
            this.Estado = estado;
        }

        public Curso(TipoCurso tipoCurso, DateTime fechaCreacion, DateTime fechaModificacion, DateTime fechaInicio,
            DateTime fechaFin, int duracion, int cupos, char estado)
        {
            this.TipoCurso = tipoCurso;
            this.FechaCreacion = fechaCreacion;
            this.FechaModificacion = fechaModificacion;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Duracion = duracion;
            this.Cupos = cupos;
            this.Estado = estado;
        }

        public int Codigo { get; set; }
        public TipoCurso TipoCurso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Duracion { get; set; }
        public int Cupos { get; set; }
        public char Estado { get; set; }

    }
}
