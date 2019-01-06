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
    public class GestorConsumidores
    {
        public static Consumidor buscarPorId(int idConsumidor)
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select * from Consumidor where idConsumidor = @idConsumidor";

            Consumidor con = null;
            SqlConnection cn = new SqlConnection(cs);
            SqlDataReader dr;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idConsumidor", idConsumidor);
                
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                         con = new Consumidor();
                         con.idConsumidor = (int)dr["idConsumidor"];
                         con.numeroDoc = (long)dr["numeroDoc"];
                    if (dr["razonSocial"] != DBNull.Value)
                        con.razonSocial = dr["razonSocial"].ToString();
                    if (dr["nombre"] != DBNull.Value)
                        con.nombre = dr["nombre"].ToString();
                    if (dr["apellido"] != DBNull.Value)
                        con.apellido = dr["apellido"].ToString();
                    if (dr["fechaNac"] != DBNull.Value)
                        con.fechaNac = (DateTime)dr["fechaNac"];
                        con.telefono = (long)dr["telefono"];
                    if (dr["direccion"] != DBNull.Value)
                        con.direccion = dr["direccion"].ToString();
                    if (dr["correo"] != DBNull.Value)
                        con.correo = dr["correo"].ToString();
                    if (dr["habilitado"] != DBNull.Value)
                        con.habilitado = (bool)dr["habilitado"];
                   // if (dr["usuarioId"] != DBNull.Value)
                   //     con.usuarioId = (int)dr["usuarioId"];
                    if (dr["barrioId"] != DBNull.Value)
                        con.barrioId = (int)dr["barrioId"];
                    if (dr["cuit"] != DBNull.Value)
                        con.cuit = dr["cuit"].ToString();
                    if (dr["puntaje"] != DBNull.Value)
                        con.puntaje =(double) dr["puntaje"];
                }
                dr.Close();
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

            return con;

        }

        public static Consumidor buscarExistenciaTel(long tel)
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select telefono from Consumidor where telefono = @tel ";


            Consumidor con =null;

            SqlConnection cn = new SqlConnection(cs);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tel", tel);
            
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    con = new Consumidor();
    
                    if (dr["telefono"] != DBNull.Value)
                        con.telefono = (long)dr["telefono"];
                   
                    
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

            return con;



        }

        public static Consumidor buscarExistenciaDni(long dni)
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select numeroDoc from Consumidor where numeroDoc = @dni ";


            Consumidor con = null;

            SqlConnection cn = new SqlConnection(cs);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    con = new Consumidor();
                    if (dr["numeroDoc"] != DBNull.Value)
                        con.numeroDoc = (long)dr["numeroDoc"];
                   


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

            return con;



        }

        public static List<Consumidor> buscarPorNombre(string nombre)
        {
               string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
               string sql = "select * from Consumidor where nombre like  @nombre";
               
                
               List<Consumidor> Consu = new List<Consumidor>();
           
               SqlConnection cn = new SqlConnection(cs);
            
            try 
	        {	        
		        SqlCommand cmd = new SqlCommand (sql,cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    Consumidor con = new Consumidor();
                    con= new Consumidor();
                    con.idConsumidor = (int) dr["idConsumidor"];
                    con.numeroDoc = (long) dr["numeroDoc"];
                    if (dr["razonSocial"] != DBNull.Value)
                    con.razonSocial = dr["razonSocial"].ToString();
                    if (dr["nombre"] != DBNull.Value)
                    con.nombre = dr["nombre"].ToString();
                    if (dr["apellido"] != DBNull.Value)
                    con.apellido = dr["apellido"].ToString();
                    if (dr["fechaNac"] != DBNull.Value)
                    con.fechaNac = (DateTime) dr["fechaNac"];
                    con.telefono = (long) dr["telefono"];
                    if (dr["direccion"] != DBNull.Value)
                    con.direccion = dr["direccion"].ToString();
                    if (dr["correo"] != DBNull.Value)
                    con.correo= dr["correo"].ToString();
                    if (dr["habilitado"] != DBNull.Value)
                    con.habilitado = (bool) dr["habilitado"];
                    if (dr["usuarioId"] != DBNull.Value)
                    con.usuarioId = (int) dr["usuarioId"];
                    if (dr["barrioId"] != DBNull.Value)
                    con.barrioId = (int) dr["barrioId"];
                    if (dr["cuit"] != DBNull.Value)
                    con.cuit =dr["cuit"].ToString();

                    Consu.Add(con);
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
        
            return Consu;



        }
    
        public static List<Consumidor> buscarTodos(string orden)
        {
               string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
               string sql = "select c.nombre,   c.idConsumidor, c.numeroDoc, c.apellido, c.direccion, c.correo, c.telefono, b.nombre as 'barrio'  from Consumidor c left join Barrio b on  c.barrioId=b.idBarrio  order by "+orden;;
               
                
               List<Consumidor> Consu = new List<Consumidor>();
           
               SqlConnection cn = new SqlConnection(cs);
            
            try 
	        {	        
		        SqlCommand cmd = new SqlCommand (sql,cn);
                
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    Consumidor con = new Consumidor();
                    con= new Consumidor();
                    con.idConsumidor = (int) dr["idConsumidor"];
                    con.numeroDoc = (long) dr["numeroDoc"];
                 //   if (dr["razonSocial"] != DBNull.Value)
                //    con.razonSocial = dr["razonSocial"].ToString();
                    if (dr["nombre"] != DBNull.Value)
                    con.nombre = dr["nombre"].ToString();
                    if (dr["apellido"] != DBNull.Value)
                        con.apellido = dr["apellido"].ToString();
                 //   if (dr["fechaNac"] != DBNull.Value)
                 //   con.fechaNac = (DateTime) dr["fechaNac"];
                    con.telefono = (long)dr["telefono"];
                    if (dr["direccion"] != DBNull.Value)
                    con.direccion = dr["direccion"].ToString();
                    if (dr["correo"] != DBNull.Value)
                    con.correo= dr["correo"].ToString();
                 //   if (dr["habilitado"] != DBNull.Value)
                //    con.habilitado = (bool) dr["habilitado"];
                //    if (dr["usuarioId"] != DBNull.Value)
                //    con.usuarioId = (int) dr["usuarioId"];
                //   if (dr["barrioId"] != DBNull.Value)
                //     con.barrioId = (int) dr["barrioId"];
                //    if (dr["cuit"] != DBNull.Value)
                //    con.cuit = (int) dr["cuit"];
                   
                   con.nombreBarrio = dr["barrio"].ToString();
                    Consu.Add(con);
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
        
            return Consu;



        }

        public static void Eliminar(int idConsumidor)
         {
             string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
             string sql = "Delete from Consumidor where idConsumidor=@idConsumidor " ;
             SqlConnection cn = new SqlConnection(cs);


             try
             {
                 SqlCommand cmd = new SqlCommand(sql, cn);
                 cmd.Parameters.Clear();
                 cmd.Parameters.AddWithValue("@idConsumidor", idConsumidor);
                 cn.Open();
                 cmd.ExecuteNonQuery();
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
        
        
        }
        
        public static void Agregar(Consumidor c)
     {
         string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
         string sql = "";
         SqlConnection cn = new SqlConnection(cs);


         try
         {
             
             if (c.idConsumidor == 0)
             {
                 sql = "insert into Consumidor ( nombre, apellido, fechaNac, numeroDoc, correo, razonSocial, cuit, telefono, barrioId , direccion , puntaje, habilitado) values ( @nombre,@apellido,@fechaNac, @numeroDoc,@correo, @razonSocial, @cuit, @telefono, @barrioId ,@direccion, @puntaje, @habilitado) "; //nombre del procedimiento q debe ir a buscar
             }
             else
             {
                 sql = "update Consumidor set nombre=@nombre,apellido=@apellido, fechaNac=@fechaNac ,numeroDoc=@numeroDoc, correo=@correo,razonSocial=@razonSocial,cuit=@cuit ,telefono=@telefono ,barrioId=@barrioId, direccion=@direccion, puntaje=@puntaje, habilitado=@habilitado where idConsumidor=@idConsumidor";
             }
             SqlCommand cmd = new SqlCommand(sql, cn);
             cmd.Parameters.Clear();
             cmd.Parameters.Add(new SqlParameter("@idConsumidor", c.idConsumidor));
             cmd.Parameters.Add(new SqlParameter("@nombre", c.nombre));
             cmd.Parameters.Add(new SqlParameter("@apellido", c.apellido));
             cmd.Parameters.Add(new SqlParameter("@fechaNac", c.fechaNac));
             cmd.Parameters.Add(new SqlParameter("@numeroDoc", c.numeroDoc));
             cmd.Parameters.Add(new SqlParameter("@correo",c.correo));
             cmd.Parameters.Add(new SqlParameter("@razonSocial",c.razonSocial ));
             cmd.Parameters.Add(new SqlParameter("@cuit",c.cuit));
             cmd.Parameters.Add(new SqlParameter("@barrioId", c.barrioId));
             cmd.Parameters.Add(new SqlParameter("@telefono", c.telefono));
             cmd.Parameters.Add(new SqlParameter("@direccion",c.direccion));
             cmd.Parameters.Add(new SqlParameter("@puntaje",c.puntaje));
             cmd.Parameters.Add(new SqlParameter("@habilitado",c.habilitado));
             cn.Open();
             cmd.ExecuteNonQuery();
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
     }

        public static bool Habilitado(string usuario)
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string sql = "select c.habilitado, u.usuario from Usuario u left join Consumidor c on c.usuarioId=u.idUsuario where u.usuario=@usuario ";


            bool habilitado = false;

            SqlConnection cn = new SqlConnection(cs);

            try
            {
                
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["usuario"].ToString()=="Admin")
                    { habilitado = true; }
                    else 
                    {if (dr["habilitado"] != DBNull.Value)
                        habilitado = (bool)dr["habilitado"];
                    }
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

            return habilitado;



        }

    }
}