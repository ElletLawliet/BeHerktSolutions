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
    class TipoIdController
    {

        public List<TipoId> FindAll()
        {
            List<TipoId> tipoIds = new List<TipoId>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoId.FIND_ALL, sqlConnection)
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
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        Convert.ToChar(sqlDataReader.GetString(3))
                        );

                    tipoIds.Add(tipoId);
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

            return tipoIds;

        }

        public List<TipoId> FindByDescription(string description)
        {
            List<TipoId> tipoIds = new List<TipoId>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoId.FIND_BY_DESCRIPCION, sqlConnection)
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
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        Convert.ToChar(sqlDataReader.GetString(3))
                        );

                    tipoIds.Add(tipoId);
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

            return tipoIds;

        }

        public TipoId FindById(char codigo)
        {
            TipoId tipoId = null;
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoId.FIND_BY_ID, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", codigo));
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    tipoId = new TipoId(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        Convert.ToChar(sqlDataReader.GetString(3))
                        );

                    
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

            return tipoId;

        }

        public void Save(TipoId tipoId)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoId.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", tipoId.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", tipoId.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", tipoId.Estado));
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

        public void Update(TipoId tipoId)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoId.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", tipoId.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", tipoId.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", tipoId.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@SECUENCIA", tipoId.Secuencia));
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

        public void Delete(TipoId tipoId)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoId.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@SECUENCIA", tipoId.Secuencia));
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
