using DulceCorEnt;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DulceCorNeg
{
    public class GestorPromociones
    {
        public static DataTable ObtenerListaPromociones(int idTipoGolosina = 0)
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select g.idGolosina, g.nombre golosina ,g.descripcion, g.disponibilidad , g.cantidadPaquete,g.imagen, g.codigo, g.tipoGolosinaId, t.nombre as nombretipoGolosina, m.nombre as marca , tp.precioProm, tp.idTipoPromocion, tp.nombre tpNom, p.nombre prom from Promocion p join TipoPromocion tp on p.idPromocion=tp.promocionId join Golosina g on tp.golosinaId = g.idGolosina join TipoGolosina t on t.idTipoGolosina = g.tipoGolosinaId join Marca m on g.tipoMarcaId = m.idMarca where (@idTipoGolosina = 0 or g.tipoGolosinaId = @idTipoGolosina) and g.disponibilidad='true'";
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(cs);
            try
            {

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idTipoGolosina", idTipoGolosina);
                cn.Open();
         
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

        public static TipoPromocion ObtenerPrecioCantProm(int idTipoProm = 0)
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select tp.precioProm , tp.cantidadPaquete, tp.golosinaId   from TipoPromocion tp join Golosina g on tp.golosinaId = g.idGolosina join TipoGolosina t on t.idTipoGolosina = g.tipoGolosinaId join Marca m on g.tipoMarcaId = m.idMarca where  tp.idTipoPromocion = @idTipoProm and g.disponibilidad='true'";
            TipoPromocion tp = null;
            SqlConnection cn = new SqlConnection(cs);
            try
            {

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idTipoProm", idTipoProm);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    tp = new TipoPromocion();
                    tp.precioProm = (decimal)dr["precioProm"];
                    tp.cantidadPaquetes = (int)dr["cantidadPaquete"];
                    tp.golosinaId = (int)dr["golosinaId"];
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

            return tp;
        }

        public static DataTable buscarInfoProm(string orden)
        {
            
            DataTable dt = new DataTable();
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select g.nombre golosina , tp.precioProm precio,  p.nombre promocion , p.vigencia, d.descuento, tp.cantidadPaquete, tp.nombre tProm  from Promocion p join TipoPromocion tp on p.idPromocion = tp.promocionId join Golosina g on tp.golosinaId = g.idGolosina join Descuento d on tp.descuentoId= d.IdDescuento order by  "+orden;
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

        public static DataTable buscarInfoPromOpciones(string nombre, DateTime fecha, string descuento, string orden)
        {

           
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql_info = "select g.nombre golosina , tp.precioProm precio,  p.nombre promocion , p.vigencia, d.descuento, tp.cantidadPaquete, tp.nombre tProm  from Promocion p join TipoPromocion tp on p.idPromocion = tp.promocionId join Golosina g on tp.golosinaId = g.idGolosina join Descuento d on tp.descuentoId= d.IdDescuento";

            string sql_nombre = " AND p.nombre like @prom +'%' ";
            string sql_fecha = " AND p.vigencia between GETDATE() and @fecha ";
            string sql_descuento = " AND d.descuento in " + descuento;
            string sql_orden = " order by "+orden;

            bool nom= false;
            bool fech = false;
            

            if (nombre != "") { sql_info += sql_nombre; nom = true; }
            if (fecha != DateTime.Today) { sql_info += sql_fecha; fech = true; }
            if (descuento != "('0')") { sql_info += sql_descuento; }

            sql_info += sql_orden;
            
            SqlConnection cn = new SqlConnection(cs);
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql_info, cn);
                cmd.CommandType = CommandType.Text;
                
                if (nom) { cmd.Parameters.AddWithValue("@prom", nombre); }
                if (fech) { cmd.Parameters.AddWithValue("@fecha", fecha); }
                
                
                
               
                cn.Open();
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

        public static void grabar(List<TipoPromocion> Lista, Promocion prom)
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

         
            SqlConnection cn = new SqlConnection(CadenaConexion);
            SqlTransaction trans = null;

            try
            {
                cn.Open();
                trans = cn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.Transaction = trans;
                cmd.CommandText = "INSERT INTO Promocion(vigencia, nombre) VALUES(@vigencia,@nombre); SELECT @@identity"; ;
                cmd.Parameters.Add(new SqlParameter("@vigencia", prom.vigencia));
                cmd.Parameters.Add(new SqlParameter("@nombre", prom.nombre));
               


                int idProm = Convert.ToInt32(cmd.ExecuteScalar());

                //cmd.ExecuteNonQuery();

                //bucle por cada detalle
                for (int i = 0; i < Lista.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO TipoPromocion(golosinaId, cantidadPaquete, nombre, promocionId,descuentoId,precioProm) VALUES(@golosinaId, @cantidadPaquete, @nombre, @promocionId,@descuentoId,@precioProm )";
                 
                    cmd.Parameters.Add(new SqlParameter("@golosinaId", Lista[i].golosinaId));
                    cmd.Parameters.Add(new SqlParameter("@cantidadPaquete", Lista[i].cantidadPaquetes));
                    cmd.Parameters.Add(new SqlParameter("@nombre", Lista[i].tipoProm));
                    cmd.Parameters.Add(new SqlParameter("@promocionId", idProm));
                    cmd.Parameters.Add(new SqlParameter("@descuentoId", Lista[i].descuento));
                    cmd.Parameters.Add(new SqlParameter("@precioProm", Lista[i].precioProm));

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    

                }


                trans.Commit();

            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
               throw new Exception("Error en la base de datos");
            }

            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }

    }
}