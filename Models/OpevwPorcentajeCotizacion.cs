using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwPorcentajeCotizacion
    {
        public decimal IdCotizacion { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public string Tipo { get; set; }
        public int? Ano { get; set; }
        public int? Nmes { get; set; }
        public string Mes { get; set; }
        public string CodigoVendedorAsignado { get; set; }
        public string Vendedor { get; set; }
        public string Estado { get; set; }
    }
}
