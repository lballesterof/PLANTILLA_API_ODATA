using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class QueryKardex
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string AlmacenNombre { get; set; }
        public string CdgProd { get; set; }
        public string CdgBarra { get; set; }
        public string NomProd { get; set; }
        public DateTime? FechaTransacion { get; set; }
        public string TipoGuia { get; set; }
        public string CodigoGenerado { get; set; }
        public string NumeroDocu { get; set; }
        public string NumeroRef { get; set; }
        public string CdgOc { get; set; }
        public string CdgOp { get; set; }
        public string Persona { get; set; }
        public string TipoTransacion { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? ImpsolesVenta { get; set; }
        public decimal? ImpdolarVenta { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Costod { get; set; }
        public decimal? CostounitSoles { get; set; }
        public decimal? CostounitDolares { get; set; }
        public decimal? TipoCambio { get; set; }
    }
}
