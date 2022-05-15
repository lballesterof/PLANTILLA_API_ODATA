using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeOcdcProrrateo
    {
        public decimal? IdOc { get; set; }
        public decimal? IdDocumento { get; set; }
        public decimal? IdProducto { get; set; }
        public string CdgGasto { get; set; }
        public decimal Secuencia { get; set; }
        public string CdgCc { get; set; }
        public decimal Importe { get; set; }
        public decimal Porcentaje { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
