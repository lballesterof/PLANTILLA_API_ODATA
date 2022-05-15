using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwServicioOt
    {
        public DateTime DdFechaRegistro { get; set; }
        public string TipoServ { get; set; }
        public string Referencia2 { get; set; }
        public string Codact { get; set; }
        public string Cuadrilla { get; set; }
        public decimal? ValorPunto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? TotalValorPunto { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Importe { get; set; }
        public string CodRef { get; set; }
        public string Nombre { get; set; }
    }
}
