using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class QueryKardexSeries
    {
        public string Almacen { get; set; }
        public string CdgProd { get; set; }
        public string CdgBarra { get; set; }
        public string NomProd { get; set; }
        public string TipoMovi { get; set; }
        public string TipoGuia { get; set; }
        public string CodigoGenerado { get; set; }
        public string CdgRef { get; set; }
        public string TipoTransacion { get; set; }
        public decimal Cantidad { get; set; }
        public string Lote { get; set; }
        public string Serie { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Costod { get; set; }
        public DateTime FechaTransacion { get; set; }
    }
}
