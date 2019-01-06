using DulceCorEnt;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DulceCorNeg
{
    public class GestorVenta
    {
        public static List<Golosina> ObtenerListaGolosinas(int idTipoGolosina = 0)
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select g.idGolosina, g.nombre, g.precio,g.descripcion, g.disponibilidad, g.tipoMarcaId, g.cantidadPaquete,g.imagen, g.codigo, g.tipoGolosinaId, t.nombre as tipoGolosinaNombre, m.nombre as marca   from Golosina g join TipoGolosina t on t.idTipoGolosina = g.tipoGolosinaId join Marca m on g.tipoMarcaId = m.idMarca where (@idTipoGolosina = 0 or g.tipoGolosinaId = @idTipoGolosina) and g.disponibilidad='true'";
            List<Golosina> lista = new List<Golosina>();
            Golosina go = null;
            SqlConnection cn = new SqlConnection(cs);
            try
            {

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idTipoGolosina", idTipoGolosina);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    go = new Golosina();
                    go.IdGolosina = (int)dr["IdGolosina"];
                    go.Nombre = dr["nombre"].ToString();
                    if (dr["precio"] != DBNull.Value)
                    {
                        go.Precio = (decimal)dr["precio"];
                    }

                    if (dr["cantidadPaquete"] != DBNull.Value)
                    {
                        go.CantidadPaquete = (int)dr["cantidadPaquete"];
                    }

                    if (dr["disponibilidad"] != DBNull.Value)
                    {
                        go.Disponibilidad = (bool)dr["disponibilidad"];
                    }

                    if (dr["descripcion"] != DBNull.Value)
                    {
                        go.Descripcion = dr["descripcion"].ToString();
                    }

                    go.TipoGolosinaNombre = dr["tipoGolosinaNombre"].ToString();
                    if (dr["tipoGolosinaId"] != DBNull.Value)
                    {
                        go.TipoGolosinaId = (int)dr["tipoGolosinaId"];
                    }

                    go.Marca = dr["marca"].ToString();
                    if (dr["tipoMarcaId"] != DBNull.Value)
                    {
                        go.TipoMarcaId = (int)dr["tipoMarcaId"];
                    }

                    go.Codigo = (int)dr["codigo"];

                    if (dr["imagen"] != DBNull.Value)
                    {
                        go.Imagen = dr["imagen"].ToString();
                    }

                    lista.Add(go);
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


        public static DataTable buscarInfoVenta(string nombre, DateTime? fecha, decimal? total, int tipoGolosina, string orden)
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection cn = new SqlConnection(CadenaConexion);
            

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.Parameters.Clear();
                cmd.Connection = cn;
                cmd.CommandText = "select g.Nombre as 'Golosina', dt.Cantidad, v.Total, t.Nombre as 'Tipo_Golosina', v.Fecha, u.Usuario FROM Venta v LEFT JOIN DetalleVenta dt ON v.IdVenta= dt.VentaID LEFT JOIN Golosina g ON g.IdGolosina = dt.GolosinaId LEFT JOIN TipoGolosina t ON g.tipoGolosinaId = t.idTipoGolosina LEFT JOIN Usuario u ON v.clienteId=u.idUsuario ";
                string where="";

                where += " g.Nombre like @Nombre";
                cmd.Parameters.Add(new SqlParameter("@Nombre","%" +  nombre + "%"));
                
                if (total != null)
                {
                    where += " and";
                    where += " v.Total >= @Total";
                    cmd.Parameters.Add(new SqlParameter("@Total", total));
                }
                if (tipoGolosina != 0)
                {
                    where += " and";
                    where += " g.tipoGolosinaId = @TipoGolosina";
                    cmd.Parameters.Add(new SqlParameter("@TipoGolosina", tipoGolosina));
                }
                if(fecha!=null)
                {
                    where += " and";
                    where += " v.Fecha <= @Fecha";
                    cmd.Parameters.Add(new SqlParameter("@Fecha", fecha));
                }
                if(where != "")
                {
                    cmd.CommandText += " where " + where;
                }
                cmd.CommandText += " order by " + orden;


                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                return dt;
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

        public static void grabar(List <ItemCarrito> Lista, int IdUsuario)
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            decimal total = Lista.Sum(x => x.SubTotal); 
            //var venta = new ( Fecha =datetime.now; idClienie=idCliente);
            //Venta v = new Venta();
            //v.Fecha = DateTime.Now;
            SqlConnection cn = new SqlConnection(CadenaConexion);
            SqlTransaction trans = null;

            try
            {
                cn.Open();
                trans = cn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.Transaction = trans;
                cmd.CommandText = "INSERT INTO Venta(fecha, hora, clienteID, total) VALUES(@Fecha,@Hora,@ClienteId,@Total); SELECT @@identity";;
                cmd.Parameters.Add(new SqlParameter("@Fecha",  DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@Hora", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@ClienteId", IdUsuario));
                cmd.Parameters.Add(new SqlParameter("@Total", total));


                int idVenta = Convert.ToInt32(cmd.ExecuteScalar());

                //cmd.ExecuteNonQuery();

                //bucle por cada detalle
                for (int i = 0; i < Lista.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO DetalleVenta(golosinaId, precio, cantidad, ventaId) VALUES(@GolosinaId, @Precio, @Cantidad, @VentaId )";
                    
                    cmd.Parameters.Add(new SqlParameter("@GolosinaId", Lista[i].IdGolosina));
                    cmd.Parameters.Add(new SqlParameter("@Precio", Lista[i].Precio));
                    cmd.Parameters.Add(new SqlParameter("@Cantidad", Lista[i].Cantidad));
                    cmd.Parameters.Add(new SqlParameter("@VentaId", idVenta));
                   
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "UPDATE Golosina SET cantidadPaquete=cantidadPaquete - @Cantidad WHERE idGolosina=@IdGolosina and cantidadPaquete - @Cantidad >=0";
                    cmd.Parameters.Add(new SqlParameter("@IdGolosina", Lista[i].IdGolosina));
                    cmd.Parameters.Add(new SqlParameter("@Cantidad", Lista[i].Cantidad));

                }


                int registrosafectados = cmd.ExecuteNonQuery();
                if(registrosafectados==0)
                {
                    throw new Exception("Venta no finalizada,no hay stock suficiente");
                }


                trans.Commit();

            }
            catch (Exception ex)
            {
                if(trans != null) trans.Rollback();
                if (ex.Message.StartsWith("Venta no finalizada,no hay stock suficiente")) throw;
                else throw new Exception("Error en la base de datos");
            }

            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }
    }
}
