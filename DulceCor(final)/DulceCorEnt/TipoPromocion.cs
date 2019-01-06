using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceCorEnt
{
    public class TipoPromocion
    {
        //tipoProm
        public int idTipoPromocion { get; set; }
        public int? descuento { get; set; }
        public string tipoProm { get; set; }
        public int cantidadPaquetes { get; set; }
        public decimal precioProm { get; set; }
        public int? golosinaId { get; set; }
        public int? promocionId { get; set; }

        //
        public string golosinaN { get; set; }

        
    }
}
