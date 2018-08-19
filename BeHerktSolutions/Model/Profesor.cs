using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Model
{
    class Profesor
    {

        public Profesor() { }

        public Profesor(int codigo, string cedula, string nombre, string apellido, 
            string direccion, string telefono, string correo ,char reside,
            TipoId tipoId, char estado)
        {
            this.Codigo = codigo;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Reside = reside;
            this.TipoId = tipoId;
            this.Estado = estado;
        }

        public Profesor(string cedula, string nombre, string apellido, string direccion,
            string telefono, string correo, char reside, TipoId tipoId, 
            char estado)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Reside = reside;
            this.TipoId = tipoId;
            this.Estado = estado;
        }

        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public TipoId TipoId { get; set; }
        public char Reside { get; set; }
        public char Estado { get; set; }

        override
        public string ToString()
        {
            return Apellido + " " + Nombre;
        }
    }
}
