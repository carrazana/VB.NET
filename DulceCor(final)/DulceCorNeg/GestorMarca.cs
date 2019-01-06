using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace DulceCorNeg
{
    public class GestorMarca
    {
        public GestorMarca()
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
                cmd.CommandText = "select * from Marca";

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
    }
}