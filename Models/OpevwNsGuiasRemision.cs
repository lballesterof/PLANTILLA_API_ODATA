using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwNsGuiasRemision
    {
        public decimal IdOc { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Proveedor { get; set; }
        public string Estado { get; set; }
        public string Moneda { get; set; }
        public decimal? IdProveedor { get; set; }
        public string Tdoc { get; set; }
        public string Numdoc { get; set; }
    }
}
