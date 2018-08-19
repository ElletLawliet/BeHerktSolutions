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
    class TipoCursoController
    {

        public List<TipoCurso> FindAll()
        {
            List<TipoCurso> tipoCursos = new List<TipoCurso>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoCurso.FIND_ALL, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TipoCurso tipoCurso = new TipoCurso(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetFloat(3),
                        Convert.ToChar(sqlDataReader.GetString(4))
                        );

                    tipoCursos.Add(tipoCurso);
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
            return tipoCursos;
        }

        public List<TipoCurso> FindByDescription(String description)
        {
            List<TipoCurso> tipoCursos = new List<TipoCurso>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoCurso.FIND_BY_DESCRIPTION, sqlConnection)
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
                    TipoCurso tipoCurso = new TipoCurso(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetFloat(3),
                        Convert.ToChar(sqlDataReader.GetString(4))
                        );

                    tipoCursos.Add(tipoCurso);
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
            return tipoCursos;
        }

        public List<TipoCurso> FindByCode(string codigo)
        {
            List<TipoCurso> tipoCursos = new List<TipoCurso>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoCurso.FIND_BY_CODIGO, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", codigo));
            try

            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TipoCurso tipoCurso = new TipoCurso(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetFloat(3),
                        Convert.ToChar(sqlDataReader.GetString(4))
                        );

                    tipoCursos.Add(tipoCurso);
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
            return tipoCursos;
        }

        public void Save(TipoCurso tipoCurso)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoCurso.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO",tipoCurso.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", tipoCurso.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@PRECIO", tipoCurso.Precio));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", tipoCurso.Estado));
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

        public void Update(TipoCurso tipoCurso)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoCurso.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", tipoCurso.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", tipoCurso.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@PRECIO", tipoCurso.Precio));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", tipoCurso.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@SECUENCIA", tipoCurso.Secuencia));
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

        public void Delete(TipoCurso tipoCurso)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoCurso.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@SECUENCIA", tipoCurso.Secuencia));
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
