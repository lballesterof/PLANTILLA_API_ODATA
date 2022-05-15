using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeConvenioPrueba
    {
        public decimal IdConvenio { get; set; }
        public decimal IdProducto { get; set; }
        public decimal NumSec { get; set; }
        public decimal Costo { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaAtencion { get; set; }
        public decimal? IdMedico { get; set; }
    }
}
