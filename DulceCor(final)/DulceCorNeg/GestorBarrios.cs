using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DulceCorNeg
{
    public class GestorBarrios
    {

        public static DataTable ObtenerTodosBarrios()
        {
            DataTable dt = new DataTable();
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select * from Barrio order by nombre ";
            SqlConnection cn = new SqlConnection(cs);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                cmd.Parameters.Clear();
                dt.Load(cmd.ExecuteReader());

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

            return dt;

        }
    }
}