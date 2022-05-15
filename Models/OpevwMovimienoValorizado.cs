using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwMovimienoValorizado
    {
        public string TipoGuia { get; set; }
        public DateTime DdFechaTransaccion { get; set; }
        public string CodigoGenerado { get; set; }
        public string CdgRef { get; set; }
        public string TipoMovi { get; set; }
        public string AlmacenNombre { get; set; }
        public string CdgProd { get; set; }
        public string CdgBarra { get; set; }
        public string NomProd { get; set; }
        public string CdgOc { get; set; }
        public string CdgOp { get; set; }
        public string Persona { get; set; }
        public decimal? TipoCambio { get; set; }
        public string NumDoc { get; set; }
        public decimal? CantDoc { get; set; }
        public decimal? PrecioDoc { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? CostoUnitSoles { get; set; }
        public decimal? ImporteSoles { get; set; }
        public decimal? CostoUnitDolar { get; set; }
        public decimal? ImporteDolar { get; set; }
    }
}
