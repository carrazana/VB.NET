using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace DulceCorEnt
{
    public class Golosina
    {
        public int IdGolosina { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int? CantidadPaquete { get; set; }
        public string Descripcion { get; set; }
        public int? TipoGolosinaId { get; set; }
        public int? TipoMarcaId { get; set; }
        public bool Disponibilidad { get; set; }
        public int Codigo { get; set; }
        public string Imagen { get; set; }
        //de otras
        public string Marca { get; set; }
        public string TipoGolosinaNombre { get; set; }
        //
        public int? Cantidad { get; set; }
    }
}