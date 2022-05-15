using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCuotaDocumentoventum
    {
        public decimal IdDocumento { get; set; }
        public decimal NumCuota { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaVcto { get; set; }
    }
}
