using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace DulceCorNeg
{
    public class GestorUsuarios
    {
        public static bool VerificarUsuarioClave(string usuario, string clave)
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select * from Usuario where usuario = @usuario and password = @password ";
            bool bandera;

            SqlConnection cn = new SqlConnection(cs);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", clave);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    bandera = true;


                }
                else
                {
                    bandera = false;
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

            return bandera;

        }
       

        public static string[] ObtenerRoles(string usuario)
        {


            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select r.nombre as 'rol' from Usuario u join Rol r on u.rolId=r.idRol where usuario = @usuario";
        

            SqlConnection cn = new SqlConnection(cs);
            string rol = "";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usuario);
           
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    rol = dr["rol"].ToString();


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

            return new string[] { rol };
            
        }

        public static int ObtenerIdUsuario(string usuario)
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
                cmd.CommandText = "select IdUsuario from Usuario where usuario=@Usuario";
                cmd.Parameters.Add(new SqlParameter("@Usuario", usuario));


                int idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                //dt.Load(cmd.ExecuteReader());
          
                return idUsuario;
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
           
        }
    }
}