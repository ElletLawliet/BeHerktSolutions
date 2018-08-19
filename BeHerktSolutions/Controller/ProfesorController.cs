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
    class ProfesorController
    {
        public List<Profesor> FindAll()
        {
            List<Profesor> profesors = new List<Profesor>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpProfesor.FIND_ALL, sqlConnection)
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
                        sqlDataReader.GetInt32(10),
                        sqlDataReader.GetString(11),
                        sqlDataReader.GetString(12),
                        Convert.ToChar(sqlDataReader.GetString(13))
                        );

                    Profesor profesor = new Profesor(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetString(4),
                        sqlDataReader.GetString(5),
                        sqlDataReader.GetString(6),
                        Convert.ToChar(sqlDataReader.GetString(8)),
                        tipoId,
                        Convert.ToChar(sqlDataReader.GetString(9))
                        );

                    profesors.Add(profesor);
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
            return profesors;
        }

        public List<Profesor> FindById(string cedula)
        {
            List<Profesor> profesors = new List<Profesor>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpProfesor.FIND_BY_ID, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CEDULA", cedula));
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TipoId tipoId = new TipoId(
                        sqlDataReader.GetInt32(10),
                        sqlDataReader.GetString(11),
                        sqlDataReader.GetString(12),
                        Convert.ToChar(sqlDataReader.GetString(13))
                        );

                    Profesor profesor = new Profesor(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetString(4),
                        sqlDataReader.GetString(5),
                        sqlDataReader.GetString(6),
                        Convert.ToChar(sqlDataReader.GetString(8)),
                        tipoId,
                        Convert.ToChar(sqlDataReader.GetString(9))
                        );

                    profesors.Add(profesor);
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
            return profesors;
        }

        public List<Profesor> FindByLastName(string lastName)
        {
            List<Profesor> profesors = new List<Profesor>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpProfesor.FIND_BY_LAST_NAME, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@APELLIDO", lastName));
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                TipoId tipoId = new TipoId(
                         sqlDataReader.GetInt32(10),
                         sqlDataReader.GetString(11),
                         sqlDataReader.GetString(12),
                         Convert.ToChar(sqlDataReader.GetString(13))
                         );

                Profesor profesor = new Profesor(
                    sqlDataReader.GetInt32(0),
                    sqlDataReader.GetString(1),
                    sqlDataReader.GetString(2),
                    sqlDataReader.GetString(3),
                    sqlDataReader.GetString(4),
                    sqlDataReader.GetString(5),
                    sqlDataReader.GetString(6),
                    Convert.ToChar(sqlDataReader.GetString(8)),
                    tipoId,
                    Convert.ToChar(sqlDataReader.GetString(9))
                    );
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return profesors;
        }


        public void Save(Profesor profesor)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpProfesor.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CEDULA",profesor.Cedula));
            sqlCommand.Parameters.Add(new SqlParameter("@NOMBRE", profesor.Nombre));
            sqlCommand.Parameters.Add(new SqlParameter("@APELLIDO", profesor.Apellido));
            sqlCommand.Parameters.Add(new SqlParameter("@DIRECCION", profesor.Direccion));
            sqlCommand.Parameters.Add(new SqlParameter("@TELEFONO", profesor.Telefono));
            sqlCommand.Parameters.Add(new SqlParameter("@CORREO", profesor.Correo));
            sqlCommand.Parameters.Add(new SqlParameter("@RESIDE", profesor.Reside));
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", profesor.TipoId.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", profesor.Estado));
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

        public void Update(Profesor profesor)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpProfesor.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CEDULA", profesor.Cedula));
            sqlCommand.Parameters.Add(new SqlParameter("@NOMBRE", profesor.Nombre));
            sqlCommand.Parameters.Add(new SqlParameter("@APELLIDO", profesor.Apellido));
            sqlCommand.Parameters.Add(new SqlParameter("@DIRECCION", profesor.Direccion));
            sqlCommand.Parameters.Add(new SqlParameter("@TELEFONO", profesor.Telefono));
            sqlCommand.Parameters.Add(new SqlParameter("@CORREO", profesor.Correo));
            sqlCommand.Parameters.Add(new SqlParameter("@RESIDE", profesor.Reside));
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", profesor.TipoId.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", profesor.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", profesor.Codigo));
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

        public void Delete(Profesor profesor)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpProfesor.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", profesor.Codigo));
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
