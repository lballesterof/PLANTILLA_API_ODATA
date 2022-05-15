using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDocumentoVentaContrato
    {
        public decimal IdDocumento { get; set; }
        public decimal IdContrato { get; set; }
        public decimal Ano { get; set; }
        public decimal Mes { get; set; }
        public decimal Cuota { get; set; }
    }
}
