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
    public class GestorGolosina
    {
        public static List<Golosina> buscarPorNombre(string nombre, string orden)
        {
            // procedimiento almacenado
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection cn = new SqlConnection(CadenaConexion);
            List<Golosina> Golosinas = new List<Golosina>();
            Golosina go = null;
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.Connection = cn;
                cmd.Parameters.Clear();
                cmd.Connection = cn;
                cmd.CommandText = "select IdGolosina,g.nombre, precio, cantidadPaquete, g.descripcion, g.TipoGolosinaId, t.nombre as 'tipoGolosinaNombre', g.tipoMarcaId,m.nombre as 'marca',disponibilidad, codigo, imagen from Golosina g LEFT JOIN Marca m ON g.tipoMarcaId = m.idMarca LEFT JOIN tipoGolosina t ON g.TipoGolosinaId = t.IdTipoGolosina WHERE g.nombre like @nombre order by " + orden;
                //cmd.CommandText = "select IdGolosina as ID,g.NOMBRE, PRECIO, cantidadPaquetes as 'CANTIDAD DEL PAQUETE',g.DESCRIPCION,g.tipoMarca,m.nombre as MARCA, DISPONIBILIDAD, CODIGO from Golosina g, Marca m where g.tipoMarca= m.idMarca and g.nombre like @nombre order by " + orden; //nombre del procedimiento q debe ir a buscar
                cmd.Parameters.Add(new SqlParameter("@nombre", "%" + nombre + "%"));
                //cmd.CommandType = CommandType.Text; // es necesario setear esta propiedad el valor por defecto es  CommandType.Text
                dr = cmd.ExecuteReader();
                // con el resultado cargar una entidad


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
                    go.Imagen = dr["imagen"].ToString();

                    Golosinas.Add(go);
                }
                dr.Close();
                return Golosinas;
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



        public static Golosina buscarPorID(int? idGolosina)
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection cn = new SqlConnection(CadenaConexion);
            Golosina go = null;
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select * from Golosina where IdGolosina = @IdGolosina ";
                cmd.Parameters.Add(new SqlParameter("@IdGolosina", idGolosina));
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
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

                    if (dr["tipoGolosinaId"] != DBNull.Value)
                    {
                        go.TipoGolosinaId = (int)dr["tipoGolosinaId"];
                    }

                    if (dr["tipoMarcaId"] != DBNull.Value)
                    {
                        go.TipoMarcaId = (int)dr["tipoMarcaId"];
                    }
                    go.Codigo = (int)dr["codigo"];
                    go.Imagen = dr["imagen"].ToString();
                }
                dr.Close();
                return go;
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

        public static void grabarGolosina(Golosina go)
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection cn = new SqlConnection(CadenaConexion);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                //cmd.CommandText = "INSERT INTO Golosina(nombre) VALUES("+ Nombre +")";

                if (go.IdGolosina == 0)
                {
                    cmd.CommandText = "INSERT INTO Golosina(nombre,precio,cantidadPaquete, descripcion, tipoGolosinaId, tipoMarcaId, disponibilidad, codigo, imagen) VALUES(@Nombre, @Precio, @Cantidad, @Descripcion, @TipoGolosina, @TipoMarca, @Disponibilidad, @Codigo, @Imagen)";
                }
                else
                {
                    cmd.CommandText = "UPDATE Golosina SET nombre=@Nombre, precio=@Precio, cantidadPaquete=@Cantidad, descripcion=@Descripcion, tipoGolosinaId=@TipoGolosina, tipoMarcaId=@TipoMarca, disponibilidad=@Disponibilidad, codigo=@Codigo, imagen=@Imagen where IdGolosina=@IdGolosina";
                    cmd.Parameters.Add(new SqlParameter("@IdGolosina", go.IdGolosina));

                }




                cmd.Parameters.Add(new SqlParameter("@Nombre", go.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Precio", go.Precio));
                if (go.CantidadPaquete == null)
                    cmd.Parameters.Add(new SqlParameter("@Cantidad", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("@Cantidad", go.CantidadPaquete));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", go.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@TipoGolosina", go.TipoGolosinaId));
                cmd.Parameters.Add(new SqlParameter("@TipoMarca", go.TipoMarcaId));
                cmd.Parameters.Add(new SqlParameter("@Disponibilidad", go.Disponibilidad));
                cmd.Parameters.Add(new SqlParameter("@Codigo", go.Codigo));
                cmd.Parameters.Add(new SqlParameter("@Imagen", go.Imagen));


                cmd.ExecuteNonQuery();

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

        public static void eliminarGolosina(int IdGolosina)
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection cn = new SqlConnection(CadenaConexion);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Golosina WHERE IdGolosina=@IdGolosina";
                cmd.Parameters.Add(new SqlParameter("@IdGolosina", IdGolosina));


                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                throw new Exception("La Golosina esta siendo usada en una transaccion");
            }

            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        public static bool existenciaCodigo(int codigo, int idGolosina = 0)
        {
            // procedimiento almacenado
            bool flag;
            string CadenaConexion = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection cn = new SqlConnection(CadenaConexion);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.Connection = cn;
                cmd.Parameters.Clear();
                cmd.Connection = cn;


                cmd.CommandText = "select * from Golosina where codigo = @Codigo";
                cmd.Parameters.Add(new SqlParameter("@Codigo", codigo));

                dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    flag = true;
                    dr.Close();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "select * from Golosina where codigo = @Codigo and idGolosina= @IdGolosina";
                    cmd.Parameters.Add(new SqlParameter("@IdGolosina", idGolosina));
                    cmd.Parameters.Add(new SqlParameter("@Codigo", codigo));
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                        flag = false;
                }
                else
                {
                    flag = false;
                }

                return flag;



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