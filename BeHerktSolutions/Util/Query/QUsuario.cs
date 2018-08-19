using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Query
{
    class QUsuario
    {
        /* <<<<< USERS QUERYS >>>>> */

        public static string FIND_ALL = "SELECT * FROM USUARIOS";

        public static string FIND_BY_ALIAS = "SELECT * FROM USUARIOS WHERE USUALIAS = @ALIAS";

        public static string SAVE = "INSERT INTO USUARIOS (USUNOMBRE,USUALIAS,USUCONTRASENA," +
            "USUFECHACREA,USUFECHAMODI, USUESTADO) " +
            "VALUES (@NOMBRE,@ALIAS,@CONTRASENA,@FECHACREA,@FECHAMODI,@ESTADO)";

        public static string UPDATE = "UPDATE USUARIOS SET USUNOMBRE = @NOMBRE, USUALIAS = @ALIAS, " +
            "USUCONTRASENA = @CONTRASENA, USUFECHACREA = @FECHACREA, USUFECHAMODI = @FECHAMODI," +
            "USUESTADO = @ESTADO WHERE USUCODIGO = @CODIGO";

        public static string DELETE = "DELETE FROM USUARIOS WHERE USUCODIGO = @CODIGO";
    }
}
