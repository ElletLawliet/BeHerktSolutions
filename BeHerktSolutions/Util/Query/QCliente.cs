using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Util.Query
{
    class QCliente
    {
        /* <<<<< CLIENTES QUERYS >>>>> */

        public static string FIND_ALL = "SELECT * FROM CLIENTES C INNER JOIN TIPOID T ON (C.TIDCODIGO = T.TIDCODIGO)";

        public static string FIND_BY_ID = "SELECT * FROM CLIENTES C INNER JOIN TIPOID T ON (C.TIDCODIGO = T.TIDCODIGO) " +
            "WHERE CLICEDULA = @CEDULA";

        public static string FIND_BY_NAME = "SELECT * FROM CLIENTES C INNER JOIN TIPOID T ON (C.TIDCODIGO = T.TIDCODIGO) " +
            "WHERE CLINOMBRE LIKE @NOMBRE";

        public static string SAVE = "INSERT INTO CLIENTES (CLICEDULA, CLINOMBRE, CLIDIRECCION, " +
            "CLITELEFONO, CLICORREO, TIDCODIGO, CLIESTADO) " +
            "VALUES (@CEDULA,@NOMBRE,@DIRECCION,@TELEFONO,@CORREO,@TIDCODIGO,@ESTADO)";

        public static string UPDATE = "UPDATE CLIENTES SET CLICEDULA = @CEDULA, CLINOMBRE = @NOMBRE, " +
            "CLIDIRECCION = @DIRECCION, CLITELEFONO = @TELEFONO, CLICORREO = @CORREO, TIDCODIGO = @TIDCODIGO," +
            "CLIESTADO = @ESTADO WHERE CLICODIGO = @CODIGO";

        public static string DELETE = "DELETE FROM CLIENTES WHERE CLICODIGO = @CODIGO";
    }
}
