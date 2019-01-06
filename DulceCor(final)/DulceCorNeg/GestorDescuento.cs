using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DulceCorNeg
{
    public class GestorDescuento
    {
        public static DataTable ObtenerTodosDescuentos()
        {
            DataTable dt = new DataTable();
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select * from Descuento ";
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
        public static int ObtenerDescuento(int? id)
        {
            
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select descuento from Descuento where idDescuento =@id  ";
            SqlConnection cn = new SqlConnection(cs);
            int desc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    desc =(int) dr["descuento"];
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

            return desc;

        }
    }
}