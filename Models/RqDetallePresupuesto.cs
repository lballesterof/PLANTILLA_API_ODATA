using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RqDetallePresupuesto
    {
        public string NumPre { get; set; }
        public string NumeroConcepto { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public decimal? Presupuestado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
