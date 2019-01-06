using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using DulceCorEnt;

namespace DulceCorNeg
{
    public class GestorTipoGolosina
    {
        public GestorTipoGolosina()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public static DataTable obtenerTodas()
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection cn = new SqlConnection(CadenaConexion);
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.Parameters.Clear();
                cmd.Connection = cn;
                cmd.CommandText = "select * from TipoGolosina";

                dt.Load(cmd.ExecuteReader());
                //cmd.CommandType = CommandType.Text; // es necesario setear esta propiedad el valor por defecto es  CommandType.Text

                // con el resultado cargar una entidad
                //format string: (0:dd/MM/yyyy)

            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return dt;
        }

        public static List<TipoGolosina> ObtenerLista()
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select idTipoGolosina, nombre from TipoGolosina";
            List<TipoGolosina> lista = new List<TipoGolosina>();
            SqlConnection cn = new SqlConnection(cs);
            try
            {

                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new TipoGolosina()
                    {
                        idTipoGolosina = dr.GetInt32(dr.GetOrdinal("idTipoGolosina")),
                        nombre = dr.GetString(dr.GetOrdinal("nombre"))
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return lista;
        }

    }
}