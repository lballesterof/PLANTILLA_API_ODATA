using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class AfiDepreciacion
    {
        public decimal Ano { get; set; }
        public decimal Mes { get; set; }
        public decimal IdProducto { get; set; }
        public string NroSerie { get; set; }
        public string SerieGenerada { get; set; }
        public decimal Importe { get; set; }
        public decimal? ImpOtro { get; set; }
        public string Moneda { get; set; }
        public string CentroCosto { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
