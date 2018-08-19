using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Sp
{
    class SpTipoPlan
    {
        /* <<<<< TIPOPLAN STORED PROCEDURES >>>>> */

        public static readonly string FIND_ALL = "SP_LISTADO_TIPOPLAN";

        public static readonly string FIND_BY_DESCRIPCION = "SP_LISTADO_TIPOPLAN_BY_DESCRIPCION";

        public static readonly string FIND_BY_CODIGO = "SP_LISTADO_TIPOPLAN_BY_CODIGO";

        public static readonly string RUD = "SP_RUD_TIPOPLAN";
    }
}
