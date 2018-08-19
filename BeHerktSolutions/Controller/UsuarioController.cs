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
    class UsuarioController
    {

        public List<Usuario> FindAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection con = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpUsuario.FIND_ALL, con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            try
            {
                con.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                  Usuario usuario = new Usuario(
                       Convert.ToInt32(reader.GetInt32(0)),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        Convert.ToChar(reader.GetString(6))
                        );

                    usuarios.Add(usuario);
                }
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                con.Close();
            }

            return usuarios;
        }

        public Usuario FindByAlias(String alias)
        {
            Usuario usuario = null;
            SqlConnection con = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpUsuario.FIND_BY_ALIAS, con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@ALIAS", alias));
            try
            {
                con.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    usuario = new Usuario(
                        Convert.ToInt32(reader.GetInt32(0)),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        Convert.ToChar(reader.GetString(6))
                        );
                }
            }
            catch(SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally{
                con.Close();
            }
            return usuario;
        }

        public void Save(Usuario usuario)
        {
            SqlConnection con = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpUsuario.RUD, con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@NOMBRE", usuario.Nombre));
            sqlCommand.Parameters.Add(new SqlParameter("@ALIAS", usuario.Alias));
            sqlCommand.Parameters.Add(new SqlParameter("@CONTRASENA", usuario.Contrasena));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHACREA", usuario.FechaCreacion));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAMODI", usuario.FechaModificacion));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", usuario.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'S'));
            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();
                
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Update(Usuario usuario)
        {
            SqlConnection con = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpUsuario.RUD, con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@NOMBRE", usuario.Nombre));
            sqlCommand.Parameters.Add(new SqlParameter("@ALIAS", usuario.Alias));
            sqlCommand.Parameters.Add(new SqlParameter("@CONTRASENA", usuario.Contrasena));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHACREA", usuario.FechaCreacion));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAMODI", usuario.FechaModificacion));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", usuario.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", usuario.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'U'));
            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();

            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(Usuario usuario)
        {
            SqlConnection con = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpUsuario.RUD, con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", usuario.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@ACTION", 'D'));
            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();

            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                con.Close();
            }
        }

    }

    





}
