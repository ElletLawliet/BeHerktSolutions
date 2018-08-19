using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Query
{
    class QCurso
    {
        /* <<<<< CURSOS QUERYS >>>>> */

        public static string FIND_ALL = "SELECT * FROM CURSOS C INNER JOIN TIPOCURSO T " +
            "ON (C.TCUCODIGO = T.TCUCODIGO)";

        public static string FIND_BY_DESCRIPTION = "SELECT * FROM CURSOS C INNER JOIN TIPOCURSO T " +
            "ON (C.TCUCODIGO = T.TCUCODIGO) WHERE T.TCUDESCRIPCION = @DESCRIPCION";

        public static string SAVE = "INSERT INTO CURSOS (TCUCODIGO, CURFECHACREA, CURFECHAMODI, " +
            "CURFECHAINI, CURFECHAFIN, CURDURACION, CURCUPOS, CURESTADO) " +
            "VALUES (@TCUCODIGO,@FECHACREA,@FECHAMODI,@FECHAINI,@FECHAFIN,@DURACION,@CUPOS,@ESTADO)";

        public static string UPDATE = "UPDATE CURSOS SET TCUCODIGO = @TCUCODIGO, CURFECHACREA = @FECHACREA, " +
            "CURFECHAMODI = @FECHAMODI, CURFECHAINI = @FECHAINI, CURFECHAFIN = @FECHAFIN, CURDURACION = @DURACION, " +
            "CURCUPOS = @CUPOS, CURESTADO = @ESTADO WHERE CURCODIGO = @CODIGO";

        public static string DELETE = "DELETE FROM CURSOS WHERE CURCODIGO = @CODIGO";

    }
}
