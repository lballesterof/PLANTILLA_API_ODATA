using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaTipoCambio
    {
        public string Moneda { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal? ValorComercial { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
