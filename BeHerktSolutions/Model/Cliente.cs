using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Model
{
    class Cliente
    {

        public Cliente() { }

        public Cliente(int codigo, string cedula, string nombre, string direccion,
            string telefono, string correo, TipoId tipoId, char estado)
        {
            this.Codigo = codigo;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.TipoId = tipoId;
            this.Estado = estado;
        }

        public Cliente(string cedula, string nombre, string direccion, string telefono,
            string correo, TipoId tipoId, char estado)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.TipoId = tipoId;
            this.Estado = estado;
        }

        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public TipoId TipoId { get; set; }
        public char Estado { get; set; }

        override
        public string ToString()
        {
            return Nombre;
        }

        
    }
}
