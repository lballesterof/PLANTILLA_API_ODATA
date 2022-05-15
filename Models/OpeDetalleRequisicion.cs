using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleRequisicion
    {
        public string Codigo { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public string CdgGasto { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }
        public string Observacion { get; set; }
        public string AfectoIgv { get; set; }
        public string Ai { get; set; }
        public string CentroCosto { get; set; }
        public string Unidad { get; set; }
        public decimal? FactorConversion { get; set; }
    }
}
