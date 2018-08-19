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
    class CursoController
    {
       
        public List<Curso> FindAll()
        {
            List<Curso> cursos = new List<Curso>();
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCurso.FIND_ALL, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    TipoCurso tipoCurso = new TipoCurso(
                        reader.GetInt32(9),
                        reader.GetString(10),
                        reader.GetString(11),
                        reader.GetFloat(12),
                        Convert.ToChar(reader.GetString(13))
                        );


                    Curso curso = new Curso(
                        reader.GetInt32(0),
                        tipoCurso,
                        reader.GetDateTime(2),
                        reader.GetDateTime(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetInt32(6),
                        reader.GetInt32(7),
                        Convert.ToChar(reader.GetString(8))
                        );

                    cursos.Add(curso);
                }
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                connection.Close();
            }

            return cursos;
        }

        public List<Curso> FindByDescription(string description)
        {
            List<Curso> cursos = new List<Curso>();
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCurso.FIND_BY_DESCRIPTION, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            }; 
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION",description));
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    TipoCurso tipoCurso = new TipoCurso(
                        reader.GetInt32(9),
                        reader.GetString(10),
                        reader.GetString(11),
                        reader.GetFloat(12),
                        Convert.ToChar(reader.GetString(13))
                        );

                    Curso curso = new Curso(
                        reader.GetInt32(0),
                        tipoCurso,
                        reader.GetDateTime(2),
                        reader.GetDateTime(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetInt32(6),
                        reader.GetInt32(7),
                        Convert.ToChar(reader.GetString(8))
                        );

                    cursos.Add(curso);
                }
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                connection.Close();
            }


            return cursos;
        }

        public void Save(Curso curso)
        {
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCurso.RUD, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            }; 
            sqlCommand.Parameters.Add(new SqlParameter("@TCUCODIGO", curso.TipoCurso.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHACREA", curso.FechaCreacion));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAMODI", curso.FechaModificacion));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAINI", curso.FechaInicio));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAFIN", curso.FechaFin));
            sqlCommand.Parameters.Add(new SqlParameter("@DURACION", curso.Duracion));
            sqlCommand.Parameters.Add(new SqlParameter("@CUPOS", curso.Cupos));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", curso.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'S'));
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void Update(Curso curso)
        {
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCurso.RUD, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@TCUCODIGO", curso.TipoCurso.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHACREA", curso.FechaCreacion));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAMODI", curso.FechaModificacion));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAINI", curso.FechaInicio));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAFIN", curso.FechaFin));
            sqlCommand.Parameters.Add(new SqlParameter("@DURACION", curso.Duracion));
            sqlCommand.Parameters.Add(new SqlParameter("@CUPOS", curso.Cupos));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", curso.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", curso.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'U'));
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void Delete(Curso curso)
        {
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(QCurso.DELETE, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", curso.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'D'));
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
