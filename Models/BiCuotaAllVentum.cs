using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class BiCuotaAllVentum
    {
        public string Ano { get; set; }
        public decimal Mes { get; set; }
        public decimal Cuota { get; set; }
        public string Vendedor { get; set; }
    }
}
