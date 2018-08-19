using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Model
{
    public class Usuario
    {

        public Usuario() { }

        public Usuario(int codigo, string nombre, string alias, string contrasena, 
            DateTime fechaCreacion, DateTime fechaModificacion, char estado)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Alias = alias;
            this.Contrasena = contrasena;
            this.FechaCreacion = fechaCreacion;
            this.FechaModificacion = fechaModificacion;
            this.Estado = estado;
        }

        public Usuario(string nombre, string alias, string contrasena,
            DateTime fechaCreacion, DateTime fechaModificacion, char estado)
        {
            this.Nombre = nombre;
            this.Alias = alias;
            this.Contrasena = contrasena;
            this.FechaCreacion = fechaCreacion;
            this.FechaModificacion = fechaModificacion;
            this.Estado = estado;
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public char Estado { get; set; }

    }
}
