using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCuotaVendedor
    {
        public string Vendedor { get; set; }
        public string Ano { get; set; }
        public decimal Mes { get; set; }
        public string Moneda { get; set; }
        public decimal Importe { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
