using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Query
{
    class QTipoCurso
    {
        /* <<<<< TIPOCURSO QUERYS >>>>> */

        public static string FIND_ALL = "SELECT * FROM TIPOCURSO";

        public static string FIND_BY_DESCRIPTION = "SELECT * FROM TIPOCURSO WHERE TCUDESCRIPCION = @DESCRIPCION";

        public static string FIND_BY_CODIGO = "SELECT * FROM TIPOCURSO WHERE TCUCODIGO = @CODIGO";

        public static string SAVE = "INSERT INTO TIPOCURSO (TCUCODIGO ,TCUDESCRIPCION, TCUPRECIO, TCUESTADO)" +
            "VALUES (@CODIGO,@DESCRIPCION,@PRECIO,@ESTADO)";

        public static string UPDATE = "UPDATE TIPOCURSO SET TCUCODIGO = @CODIGO , TCUDESCRIPCION = @DESCRIPCION, " +
            "TCUPRECIO = @PRECIO, TCUESTADO = @ESTADO WHERE TCUSECUENCIA = @SECUENCIA";

        public static string DELETE = "DELETE FROM TIPOCURSO WHERE TCUSECUENCIA = @SECUENCIA";

    }
}
