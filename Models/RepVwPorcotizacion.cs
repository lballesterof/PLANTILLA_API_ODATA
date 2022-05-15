using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwPorcotizacion
    {
        public decimal? Porcentaje { get; set; }
        public string Vendedor { get; set; }
        public string TipoOferta { get; set; }
        public string DdFechaHoy { get; set; }
        public string Titulo { get; set; }
    }
}
