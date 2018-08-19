using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Sp
{
    class SpProfesor
    {
        /* <<<<< PROFESORES STORED PROCEDURES >>>>> */

        public static readonly string FIND_ALL = "SP_LISTADO_PROFESORES";

        public static readonly string FIND_BY_ID = "SP_LISTADO_PROFESORES_BY_ID";

        public static readonly string FIND_BY_LAST_NAME = "SP_LISTADO_PROFESORES_BY_APELLIDO";

        public static readonly string RUD = "SP_RUD_PROFESORES";
    }
}
