using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class FeDetalleResumenBaja
    {
        public string CodigoEmpresa { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public decimal NumItem { get; set; }
        public string Tdoc { get; set; }
        public string Serie { get; set; }
        public decimal Correlativo { get; set; }
        public string Numdoc { get; set; }
        public string TipoDocumento { get; set; }
        public string Motivo { get; set; }
        public decimal? IdDocumento { get; set; }
    }
}
