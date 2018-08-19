using BeHerktSolutions.Model;
using BeHerktSolutions.Util;
using BeHerktSolutions.Util.Query;
using BeHerktSolutions.Util.Sp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Controller
{
    class TipoDescuentoController
    {
        public List<TipoDescuento> FindAll()
        {
            List<TipoDescuento> tipoDescuentos = new List<TipoDescuento>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoDescuento.FIND_ALL, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {

                    TipoId tipoId = new TipoId(
                        sqlDataReader.GetInt32(6),
                        sqlDataReader.GetString(7),
                        sqlDataReader.GetString(8),
                        Convert.ToChar(sqlDataReader.GetString(9))
                        );

                    TipoDescuento tipoDescuento = new TipoDescuento(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        tipoId,
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetInt32(4),
                        Convert.ToChar(sqlDataReader.GetString(5))
                        );

                    tipoDescuentos.Add(tipoDescuento);
                }
            }
            catch(SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

            return tipoDescuentos;
        }

        public List<TipoDescuento> FindByDescription(string description)
        {
            List<TipoDescuento> tipoDescuentos = new List<TipoDescuento>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoDescuento.FIND_BY_DESCRIPTION, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", description));
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {

                    TipoId tipoId = new TipoId(
                        sqlDataReader.GetInt32(6),
                        sqlDataReader.GetString(7),
                        sqlDataReader.GetString(8),
                        Convert.ToChar(sqlDataReader.GetString(9))
                        );

                    TipoDescuento tipoDescuento = new TipoDescuento(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        tipoId,
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetInt32(4),
                        Convert.ToChar(sqlDataReader.GetString(5))
                        );

                    tipoDescuentos.Add(tipoDescuento);
                }
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

            return tipoDescuentos;
        }

        public void Save(TipoDescuento tipoDescuento)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoDescuento.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", tipoDescuento.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", tipoDescuento.TipoId.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", tipoDescuento.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@MULTIPLO", tipoDescuento.Multiplo));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", tipoDescuento.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'S'));
            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Update(TipoDescuento tipoDescuento)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoDescuento.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", tipoDescuento.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", tipoDescuento.TipoId.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", tipoDescuento.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@MULTIPLO", tipoDescuento.Multiplo));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", tipoDescuento.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@SECUENCIA", tipoDescuento.Secuencia));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'U'));
            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Delete(TipoDescuento tipoDescuento)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoDescuento.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@SECUENCIA", tipoDescuento.Secuencia));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'D'));
            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
        }



    }
}
