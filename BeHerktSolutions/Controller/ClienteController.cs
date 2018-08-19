using BeHerktSolutions.Model;
using BeHerktSolutions.Util;

using BeHerktSolutions.Util.Sp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHerktSolutions.Controller
{
    class ClienteController
    {

        public List<Cliente> FindAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCliente.FIND_ALL, sqlConnection)
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
                        sqlDataReader.GetInt32(8),
                        sqlDataReader.GetString(9),
                        sqlDataReader.GetString(10),
                        Convert.ToChar(sqlDataReader.GetString(11))
                        );

                    Cliente cliente = new Cliente(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetString(4),
                        sqlDataReader.GetString(5),
                        tipoId,
                        Convert.ToChar(sqlDataReader.GetString(7))
                        );

                    clientes.Add(cliente);
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

            return clientes;
        }

        public List<Cliente> FindById(string cedula)
        {
            List<Cliente> clientes = new List<Cliente>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCliente.FIND_BY_ID, sqlConnection)
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
                        sqlDataReader.GetInt32(8),
                        sqlDataReader.GetString(9),
                        sqlDataReader.GetString(10),
                        Convert.ToChar(sqlDataReader.GetString(11))
                        );

                    Cliente cliente = new Cliente(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetString(4),
                        sqlDataReader.GetString(5),
                        tipoId,
                        Convert.ToChar(sqlDataReader.GetString(7))
                        );

                    clientes.Add(cliente);
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

            return clientes;
        }

        public List<Cliente> FindByName(string nombre)
        {
            List<Cliente> clientes = new List<Cliente>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCliente.FIND_BY_NAME, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@NOMBRE",nombre));
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TipoId tipoId = new TipoId(
                        sqlDataReader.GetInt32(8),
                        sqlDataReader.GetString(9),
                        sqlDataReader.GetString(10),
                        Convert.ToChar(sqlDataReader.GetString(11))
                        );

                    Cliente cliente = new Cliente(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetString(4),
                        sqlDataReader.GetString(5),
                        tipoId,
                        Convert.ToChar(sqlDataReader.GetString(7))
                        );

                    clientes.Add(cliente);
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

            return clientes;
        }

        public void Save(Cliente cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCliente.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CEDULA", cliente.Cedula));
            sqlCommand.Parameters.Add(new SqlParameter("@NOMBRE", cliente.Nombre));
            sqlCommand.Parameters.Add(new SqlParameter("@DIRECCION", cliente.Direccion));
            sqlCommand.Parameters.Add(new SqlParameter("@TELEFONO", cliente.Telefono));
            sqlCommand.Parameters.Add(new SqlParameter("@CORREO", cliente.Correo));
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", cliente.TipoId.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", cliente.Estado));
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

        public void Update(Cliente cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCliente.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CEDULA", cliente.Cedula));
            sqlCommand.Parameters.Add(new SqlParameter("@NOMBRE", cliente.Nombre));
            sqlCommand.Parameters.Add(new SqlParameter("@DIRECCION", cliente.Direccion));
            sqlCommand.Parameters.Add(new SqlParameter("@TELEFONO", cliente.Telefono));
            sqlCommand.Parameters.Add(new SqlParameter("@CORREO", cliente.Correo));
            sqlCommand.Parameters.Add(new SqlParameter("@TIDCODIGO", cliente.TipoId.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", cliente.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", cliente.Codigo));
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

        public void Delete(Cliente cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpCliente.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", cliente.Codigo));
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
