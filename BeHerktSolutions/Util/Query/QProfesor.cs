using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Query
{
    class QProfesor
    {
        /* <<<<< PROFESORES QUERYS >>>>> */

        public static string FIND_ALL = "SELECT * FROM PROFESORES P INNER JOIN TIPOID T ON (P.TIDCODIGO = T.TIDCODIGO)";

        public static string FIND_BY_ID = "SELECT * FROM PROFESORES P INNER JOIN TIPOID T ON (P.TIDCODIGO = T.TIDCODIGO) " +
            "WHERE P.PROCEDULA = @CEDULA";

        public static string FIND_BY_LAST_NAME = "SELECT * FROM PROFESORES P INNER JOIN TIPOID T ON (P.TIDCODIGO = T.TIDCODIGO) " +
            "WHERE P.PROAPELLIDO LIKE  '%@APELLIDO%'";

        public static string SAVE = "INSERT INTO PROFESORES (PROCEDULA, PRONOMBRE, PROAPELLIDO, PRODIRECCION, " +
            "PROTELEFONO, PROCORREO ,PRORESIDE, TIDCODIGO,  PROESTADO) " +
            "VALUES (@CEDULA,@NOMBRE,@APELLIDO,@DIRECCION,@TELEFONO,@CORREO,@RESIDE,@TIDCODIGO,@ESTADO)";

        public static string UPDATE = "UPDATE PROFESORES SET PROCEDULA = @CEDULA, PRONOMBRE = @NOMBRE, " +
            "PROAPELLIDO = @APELLIDO, PRODIRECCION = @DIRECCION, PROTELEFONO = @TELEFONO, PROCORREO = @CORREO, " +
            "PRORESIDE = @RESIDE, TIDCODIGO = @TIDCODIGO, PROESTADO = @ESTADO WHERE PROCODIGO = @CODIGO";

        public static string DELETE = "DELETE FROM PROFESORES WHERE PROCODIGO = @CODIGO";
    }
}
