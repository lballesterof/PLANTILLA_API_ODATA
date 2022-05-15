using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwCotizacionKit
    {
        public decimal IdCotizacion { get; set; }
        public string CdgKit { get; set; }
        public string Nombre { get; set; }
        public decimal? CantKit { get; set; }
        public string Unidad { get; set; }
    }
}
