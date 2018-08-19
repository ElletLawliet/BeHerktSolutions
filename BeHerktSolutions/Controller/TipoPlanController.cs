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
    class TipoPlanController
    {

        public List<TipoPlan> FindAll()
        {
            List<TipoPlan> tipoPlans = new List<TipoPlan>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoPlan.FIND_ALL, sqlConnection)
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
                        sqlDataReader.GetInt32(12),
                        sqlDataReader.GetString(13),
                        sqlDataReader.GetString(14),
                        Convert.ToChar(sqlDataReader.GetString(15))
                        );

                    TipoDescuento tipoDescuento = new TipoDescuento(
                        sqlDataReader.GetInt32(6),
                        sqlDataReader.GetString(7),
                        tipoId,
                        sqlDataReader.GetString(9),
                        sqlDataReader.GetInt32(10),
                        Convert.ToChar(sqlDataReader.GetString(11))
                        );

                    TipoPlan tipoPlan = new TipoPlan(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        tipoDescuento,
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetInt32(4),
                        Convert.ToChar(sqlDataReader.GetString(5))
                        );

                    tipoPlans.Add(tipoPlan);
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
            return tipoPlans;
        }

        public List<TipoPlan> FindByDescription(string description)
        {
            List<TipoPlan> tipoPlans = new List<TipoPlan>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoPlan.FIND_BY_DESCRIPCION, sqlConnection)
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
                        sqlDataReader.GetInt32(12),
                        sqlDataReader.GetString(13),
                        sqlDataReader.GetString(14),
                        Convert.ToChar(sqlDataReader.GetString(15))
                        );

                    TipoDescuento tipoDescuento = new TipoDescuento(
                        sqlDataReader.GetInt32(6),
                        sqlDataReader.GetString(7),
                        tipoId,
                        sqlDataReader.GetString(9),
                        sqlDataReader.GetInt32(10),
                        Convert.ToChar(sqlDataReader.GetString(11))
                        );

                    TipoPlan tipoPlan = new TipoPlan(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        tipoDescuento,
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetInt32(4),
                        Convert.ToChar(sqlDataReader.GetString(5))
                        );

                    tipoPlans.Add(tipoPlan);
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
            return tipoPlans;
        }

        public List<TipoPlan> FindByCode(string codigo)
        {
            List<TipoPlan> tipoPlans = new List<TipoPlan>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoPlan.FIND_BY_CODIGO, sqlConnection)
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
                    TipoId tipoId = new TipoId(
                        sqlDataReader.GetInt32(12),
                        sqlDataReader.GetString(13),
                        sqlDataReader.GetString(14),
                        Convert.ToChar(sqlDataReader.GetString(15))
                        );

                    TipoDescuento tipoDescuento = new TipoDescuento(
                        sqlDataReader.GetInt32(6),
                        sqlDataReader.GetString(7),
                        tipoId,
                        sqlDataReader.GetString(9),
                        sqlDataReader.GetInt32(10),
                        Convert.ToChar(sqlDataReader.GetString(11))
                        );

                    TipoPlan tipoPlan = new TipoPlan(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        tipoDescuento,
                        sqlDataReader.GetString(3),
                        sqlDataReader.GetInt32(4),
                        Convert.ToChar(sqlDataReader.GetString(5))
                        );

                    tipoPlans.Add(tipoPlan);
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
            return tipoPlans;
        }

        public void Save(TipoPlan tipoPlan)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoPlan.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", tipoPlan.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@TDCCODIGO", tipoPlan.TipoDescuento.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", tipoPlan.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@PORCENTAJE", tipoPlan.Porcentaje));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", tipoPlan.Estado));
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

        public void Update(TipoPlan tipoPlan)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoPlan.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@CODIGO", tipoPlan.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@TDCCODIGO", tipoPlan.TipoDescuento.Codigo));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", tipoPlan.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@PORCENTAJE", tipoPlan.Porcentaje));
            sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", tipoPlan.Estado));
            sqlCommand.Parameters.Add(new SqlParameter("@SECUENCIA", tipoPlan.Secuencia));
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

        public void Delete(TipoPlan tipoPlan)
        {
            SqlConnection sqlConnection = new SqlConnection(Utilities.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(SpTipoPlan.RUD, sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@SECUENCIA", tipoPlan.Secuencia));
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
