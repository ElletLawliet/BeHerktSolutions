using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Query
{
    class QTipoId
    {
        /* <<<<< TIPOID QUERYS >>>>> */

        public static string FIND_ALL = "SELECT * FROM TIPOID";

        public static string FIND_BY_ID = "SELECT * FROM TIPOID WHERE TIDCODIGO = @CODIGO";

        public static string FIND_BY_DESCRIPCION = "SELECT * FROM TIPOID WHERE TIDCODIGO = @TIDCODIGO " +
            "WHERE TIDDESCRIPCION = @DESCRIPCION";

        public static string SAVE = "INSERT INTO TIPOID (TIDCODIGO, TIDDESCRIPCION, TIDESTADO) " +
            "VALUES (@CODIGO,@DESCRIPCION,@ESTADO)";

        public static string UPDATE = "UPDATE TIPOID SET TIDCODIGO = @CODIGO, TIDDESCRIPCION = @DESCRIPCION, " +
            "TIDESTADO = @ESTADO WHERE TIDSECUENCIA = @SECUENCIA";

        public static string DELETE = "DELETE FROM TIPOID WHERE TIDSECUENCIA = @SECUENCIA";


    }
}
