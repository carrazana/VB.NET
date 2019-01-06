using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DulceCorEnt
{
    public class Consumidor
    {
        public int idConsumidor { get; set; }
        public long numeroDoc { get; set; }
        public string razonSocial { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime? fechaNac { get; set; }
        public long telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public bool? habilitado { get; set; }
        public double? puntaje { get; set; }
        public int? usuarioId { get; set; }
        public int? barrioId { get; set; }
        public string cuit { get; set; }
        //barrio
        public string nombreBarrio { get; set; }
   
    }
}