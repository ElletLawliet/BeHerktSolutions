using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Query
{
    class QTipoDescuento
    {
        /* <<<<< TIPODESCUENTO QUERYS >>>>> */

        public static string FIND_ALL = "SELECT * FROM TIPODESCUENTO";

        public static string FIND_BY_DESCRIPTION = "SELECT * FROM TIPODESCUENTO WHERE TDCDESCRIPCION LIKE '@DESCRIPCION%'";

        public static string SAVE = "INSERT INTO TIPODESCUENTO (TDCCODIGO, TIDCODIGO, TDCDESCRIPCION, TDCMULTIPLO, " +
            "TDCESTADO) " +
            "VALUES (@CODIGO,@TIDCODIGO,@DESCRIPCION,@MULTIPLO,@ESTADO)";

        public static string UPDATE = "UPDATE TIPODESCUENTO SET TDCCODIGO = @CODIGO, TIDCODIGO = @TIDCODIGO, " +
            "TDCDESCRIPCION = @DESCRIPCION, TDCMULTIPLO = @MULTIPLO, TDCESTADO = @ESTADO WHERE TDCSECUENCIA = @SECUENCIA ";

        public static string DELETE = "DELETE FROM TIPODESCUENTO WHERE TDCSECUENCIA = @SECUENCIA";

    }
}
